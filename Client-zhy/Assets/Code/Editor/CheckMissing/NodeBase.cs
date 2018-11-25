using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YamlParser
{
    public class NodeBase
    {
        protected string mFileID = "-1";

        public string FileID
        {
            get
            {
                return mFileID;
            }
            set
            {
                mFileID = value;
            }
        }

        public NodeBase()
        {

        }
        public virtual void Begin()
        {

        }

        public virtual void End()
        {

        }

        public virtual void Append(string line)
        {

        }

        /// <summary>
        /// 共用解析方法
        /// </summary>
        /// <param name="line">适用于m_PrefabInternal: {fileID: 100100000}格式</param>
        /// <returns></returns>
        protected string GetOneFileID(string line)
        {
            return line.Replace(" ", "").Replace("}", "").Split(':')[2];
        }

        protected string GetName(string line)
        {
            return line.Replace(" ", "").Split(':')[1];
        }
    }
}
