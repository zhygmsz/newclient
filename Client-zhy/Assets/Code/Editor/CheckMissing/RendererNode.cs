using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YamlParser
{
    //假定，只有XXXRenderer里有m_Materials
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

        //现在问题是，材质有多个的时候，这里又没有sr，该如判断当前line
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
