using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YamlParser
{
    public class MonoBehaviourNode : NodeBase
    {
        protected string mPrefabInternal;
        protected string mGameObject;
        protected string mScriptGUID;
        protected string mScriptFileID;
        protected int mScriptType;


        public string PrefabInternalFileID
        {
            get { return mPrefabInternal; }
        }

        public string GameObjectFileID
        {
            get { return mGameObject; }
        }

        public string ScriptGUID
        {
            get { return mScriptGUID; }
        }

        public string ScriptFileID
        {
            get { return mScriptFileID; }
        }

        public int ScriptType
        {
            get { return mScriptType; }
        }

        public MonoBehaviourNode()
        {

        }

        public override void Begin()
        {
            base.Begin();

        }

        public override void End()
        {
            base.End();
        }

        public override void Append(string line)
        {
            base.Append(line);
            if (line.Contains("m_PrefabInternal"))
            {
                mPrefabInternal = GetOneFileID(line);
            }
            else if (line.Contains("m_GameObject"))
            {
                mGameObject = GetOneFileID(line);
            }
            else if (line.Contains("m_Script") && line.Contains("fileID") && line.Contains("guid"))
            {
                string[] lines = line.Replace(" ", "").Split(',');
                mScriptFileID = lines[0].Split(':')[2];
                mScriptGUID = lines[1].Split(':')[1];
                mScriptType = int.Parse(lines[2].Replace("}", "").Split(':')[1]);
            }
        }
    }
}
