﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YamlParser
{
    public class GameObjectNode : NodeBase
    {
        private string mName;

        public string Name
        {
            get { return mName; }
        }

        public GameObjectNode()
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
            if (line.Contains("m_Name"))
            {
                mName = GetName(line);
            }
        }
    }
}
