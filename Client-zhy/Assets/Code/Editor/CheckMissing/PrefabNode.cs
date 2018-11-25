using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YamlParser
{
    public class PrefabNode : NodeBase
    {
        //记录该Prefab的RootGameObject对应的fileID
        private string mRootGameObject = "-1";

        public string RootGameObjectFileID
        {
            get
            {
                return mRootGameObject;
            }
        }

        public PrefabNode()
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
            if (line.Contains("m_RootGameObject"))
            {
                mRootGameObject = GetOneFileID(line);
            }
        }
    }
}
