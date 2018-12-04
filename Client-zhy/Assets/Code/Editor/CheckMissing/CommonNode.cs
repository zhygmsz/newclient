using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YamlParser
{
    public struct CommonNode
    {
        private string mFileID;
        private string mGoFileID;
        private string mGUID;

        public string FileID
        {
            get { return mFileID; }
        }

        public string GoFileID
        {
            get { return mGoFileID; }
        }

        public string GUID
        {
            get { return mGUID; }
        }

        public CommonNode(string fileID, string goFileID, string guid)
        {
            mFileID = fileID;
            mGoFileID = goFileID;
            mGUID = guid;
        }
    }
}
