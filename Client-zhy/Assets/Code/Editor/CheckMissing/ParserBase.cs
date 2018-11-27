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
        protected Dictionary<string, CommonNode> mScriptNodeDic = new Dictionary<string, CommonNode>();
        protected Dictionary<string, CommonNode> mMatNodeDic = new Dictionary<string, CommonNode>();
        protected Dictionary<string, CommonNode> mShaderNodeDic = new Dictionary<string, CommonNode>();


        public ParserBase(string path)
        {
            mPath = path;
            Parse();
        }

        public void LogScriptMissing(HashSet<string> guidSet)
        {
            foreach (KeyValuePair<string, CommonNode> kvp in mScriptNodeDic)
            {
                if (!guidSet.Contains(kvp.Value.GUID))
                {
                    string goName = mGoNodeDic[kvp.Value.GoFileID].Name;
                    string log = string.Format("path = {0}, guid = {1}, goName = {2}", mPath, kvp.Value.GUID, goName);
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
                    //计算出m_GameObject对应的fileID
                    goFileID = line.Replace(" ", "").Replace("}", "").Split(':')[2];
                }
                else if (line.Contains("fileID") && line.Contains("guid"))
                {
                    //根据不同的fileID判断具体的node类型
                }
            }
        }
    }
}
