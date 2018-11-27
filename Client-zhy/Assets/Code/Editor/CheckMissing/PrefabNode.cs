using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YamlParser
{
    public struct PrefabNode
    {
        private string mRootGoFileID;

        public string RootGoFileID
        {
            get { return mRootGoFileID; }
        }

        public PrefabNode(string rootGoFileID)
        {
            mRootGoFileID = rootGoFileID;
        }
    }
}
