using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class AppConst
{
    static public string AssetPath;
    static public string UIPrefabPath;

    static AppConst()
    {
        AssetPath = Application.dataPath;
        UIPrefabPath = "Assets/Res/UI/Prefab/";
    }
    

}