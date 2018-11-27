using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YamlParser
{
    public struct GoNode
    {
        private string mFileID;
        private string mName;

        public string Name
        {
            get { return mName; }
        }

        public string FileID
        {
            get { return mFileID; }
        }

        public GoNode(string fileID, string name)
        {
            mFileID = fileID;
            mName = name;
        }
    }
}
