using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YamlParser
{
    public class RendererNode : NodeBase
    {
        protected string mGameObjectFileID;


        public string GameObjectFileID
        {
            get { return mGameObjectFileID; }
        }


        public RendererNode()
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
            if (line.Contains("m_GameObject"))
            {
                mGameObjectFileID = GetOneFileID(line);
            }
        }
    }
}
