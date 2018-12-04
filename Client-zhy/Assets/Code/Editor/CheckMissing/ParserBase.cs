using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace YamlParser
{
    public class ParserBase
    {
        protected string mPath;

        protected Dictionary<string, PrefabNode> mPrefabNodeDic = new Dictionary<string, PrefabNode>();
        protected Dictionary<string, GoNode> mGoNodeDic = new Dictionary<string, GoNode>();
        protected List<CommonNode> mScriptNodeList = new List<CommonNode>();
        protected List<CommonNode> mMatNodeList = new List<CommonNode>();
        protected List<CommonNode> mShaderNodeList = new List<CommonNode>();


        public ParserBase(string path)
        {
            mPath = path;
            Parse();
        }

        public void LogScriptMissing(HashSet<string> guidSet)
        {
            foreach (CommonNode node in mScriptNodeList)
            {
                if (!guidSet.Contains(node.GUID))
                {
                    string goName = mGoNodeDic[node.GoFileID].Name;
                    string log = string.Format("path = {0}, guid = {1}, goName = {2}", mPath, node.GUID, goName);
                    Debug.LogError(log);
                }
            }
        }

        public void LogMatMissing(HashSet<string> guidSet)
        {
            foreach (CommonNode node in mMatNodeList)
            {
                if (!guidSet.Contains(node.GUID))
                {
                    string goName = mGoNodeDic[node.GoFileID].Name;
                    string log = string.Format("path = {0}, guid = {1}, goName = {2}", mPath, node.GUID, goName);
                    Debug.LogError(log);
                }
            }
        }

        public void LogShaderMissing(HashSet<string> guidSet)
        {
            foreach (CommonNode node in mShaderNodeList)
            {
                if (!guidSet.Contains(node.GUID))
                {
                    string goName = mGoNodeDic[node.GoFileID].Name;
                    string log = string.Format("path = {0}, guid = {1}, goName = {2}", mPath, node.GUID, goName);
                    Debug.LogError(log);
                }
            }
        }


        protected virtual void Parse()
        {
            FileStream fs = File.OpenRead(mPath);
            StreamReader sr = new StreamReader(fs);
            string line = "";
            string fileID = "";
            string goFileID = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                if (line.Contains("---"))
                {
                    //计算出fileID
                    fileID = line.Replace(" ", "").Split('&')[1];
                    string classID = line.Replace(" ", "").Split('!', '&')[2];
                    if (classID == "1")
                    {
                        //GameObject，假定1000行内能找到该GameObject的m_Name字段
                        //如果GameObject上挂在的Component数量超过1000个，则该循环失效，但这种情况几乎不可能
                        for (int idx = 1, count = 1000; idx <= count; ++idx)
                        {
                            line = sr.ReadLine();
                            if (line.Contains("m_Name"))
                            {
                                string goName = line.Replace(" ", "").Split(':')[1];
                                GoNode newGoNode = new GoNode(fileID, goName);
                                mGoNodeDic.Add(fileID, newGoNode);
                                break;
                            }
                        }
                    }
                }
                else if (line.Contains("m_GameObject"))
                {
                    //计算出该组件对应的m_GameObject的fileID
                    goFileID = line.Replace(" ", "").Replace("}", "").Split(':')[2];
                }
                else if (line.Contains("fileID") && line.Contains("guid"))
                {
                    string curFileID = line.Replace(" ", "").Split('{')[1].Split('}')[0].Split(',')[0].Split(':')[1];
                    string curGUID = line.Replace(" ", "").Split('{')[1].Split('}')[0].Split(',')[1].Split(':')[1];
                    CommonNode newCommonNode = new CommonNode(fileID, goFileID, curGUID);
                    //根据不同的fileID判断具体的node类型
                    if (curFileID == "11500000")
                    {
                        //script
                        mScriptNodeList.Add(newCommonNode);
                    }
                    else if (curFileID == "2100000")
                    {
                        //material
                        mMatNodeList.Add(newCommonNode);
                    }
                    else if (curFileID == "4800000")
                    {
                        //shader
                        mShaderNodeList.Add(newCommonNode);
                    }
                }
            }
        }
    }
}
