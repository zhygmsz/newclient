﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace YamlParser
{
    //给个prefab路径，解析出其各种节点结构，最后保存各种节点结构
    public class PrefabParser : ParserBase
    {
        
        public PrefabParser(string path) : base(path)
        {
            
        }

        protected override void Parse()
        {
            base.Parse();
        }
    }
}
