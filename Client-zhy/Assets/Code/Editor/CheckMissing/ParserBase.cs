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
        protected Dictionary<string, GameObjectNode> mGameObjectNodeDic = new Dictionary<string, GameObjectNode>();
        protected Dictionary<string, MonoBehaviourNode> mMonoBehaviourNodeDic = new Dictionary<string, MonoBehaviourNode>();

        
        public ParserBase(string path)
        {
            mPath = path;
            Parse();
        }

        public void LogScriptMissing(HashSet<string> guidSet)
        {
            foreach (KeyValuePair<string, MonoBehaviourNode> kvp in mMonoBehaviourNodeDic)
            {
                if (!guidSet.Contains(kvp.Value.ScriptGUID))
                {
                    string goName = mGameObjectNodeDic[kvp.Value.GameObjectFileID].Name;
                    string log = string.Format("path = {0}, guid = {1}, goName = {2}", mPath, kvp.Value.ScriptGUID, goName);
                    Debug.LogError(log);
                }
            }
        }

        protected virtual void Parse()
        {
            FileStream fs = File.OpenRead(mPath);
            StreamReader sr = new StreamReader(fs);
            NodeBase node = null;
            string line = "";
            string fileID = "";
            string nodeName = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                if (line.Contains("---"))
                {
                    //上一个node（如果存在）结束并缓存
                    if (node != null && fileID != "")
                    {
                        node.End();
                        AddNode(fileID, node);
                    }

                    fileID = line.Replace(" ", "").Split('&')[1];
                    line = sr.ReadLine();
                    nodeName = line.Split(':')[0];
                    node = GetNode(nodeName);
                    if (node != null)
                    {
                        node.Begin();
                    }
                }
                else if (node != null)
                {
                    node.Append(line);
                }
            }
            //最后一个node
            if (node != null && fileID != "")
            {
                node.End();
                AddNode(fileID, node);
            }
        }


        protected NodeBase GetNode(string nodeName)
        {
            NodeBase node = null;
            if (nodeName == "Prefab")
            {
                node = new PrefabNode();
            }
            else if (nodeName == "GameObject")
            {
                node = new GameObjectNode();
            }
            else if (nodeName == "MonoBehaviour")
            {
                node = new MonoBehaviourNode();
            }
            else
            {

            }
            return node;
        }

        protected void AddNode(string fileID, NodeBase node)
        {
            node.FileID = fileID;
            if (node is PrefabNode)
            {
                AddPrefabNode(fileID, (PrefabNode)node);
            }
            else if (node is GameObjectNode)
            {
                AddGameObjectNode(fileID, (GameObjectNode)node);
            }
            else if (node is MonoBehaviourNode)
            {
                AddMonoBehaviourNode(fileID, (MonoBehaviourNode)node);
            }
        }

        private void AddPrefabNode(string fileID, PrefabNode node)
        {
            mPrefabNodeDic.Add(fileID, node);
        }

        private void AddGameObjectNode(string fileID, GameObjectNode node)
        {
            mGameObjectNodeDic.Add(fileID, node);
        }

        private void AddMonoBehaviourNode(string fileID, MonoBehaviourNode node)
        {
            mMonoBehaviourNodeDic.Add(fileID, node);
        }
    }
}
