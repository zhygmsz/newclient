using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;


public class Utils
{
    public static GameObject NewGameObject(Transform parent, bool dontDestroy)
    {
        GameObject newGo = new GameObject();
        newGo.transform.parent = parent;

        if (dontDestroy)
        {
            GameObject.DontDestroyOnLoad(newGo);
        }

        return newGo;
    }

    public static void Log(string str)
    {
        Debugger.Log(str);
    }

    public static void LoagWarning(string str)
    {
        Debugger.LogWarning(str);
    }

    public static void LogError(string str)
    {
        Debugger.LogError(str);
    }
}
