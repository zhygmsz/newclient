﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏启动
/// </summary>
public class GameStart : MonoBehaviour
{
    private GameObject mLuaManagerObj;
    private LuaManager mLuaMgr;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        mLuaManagerObj = Utils.NewGameObject(transform, true);
        mLuaManagerObj.name = "LuaManager";
        mLuaMgr = mLuaManagerObj.AddComponent<LuaManager>();
    }

    private void Start()
    {
        mLuaMgr.StartMain();
    }
}
