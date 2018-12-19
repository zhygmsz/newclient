﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorUtils
{
    [MenuItem("Assets/工具集/列出UIPrefab上的所有UIPanel")]
    public static void LogUIPanelOfUIPrefab()
    {
        UnityEngine.Object obj = Selection.activeObject;
        if (obj == null)
        {
            return;
        }
        GameObject go = obj as GameObject;
        if (go == null)
        {
            return;
        }
        Transform trs = go.transform;
        LogUIPanel(trs, trs.name);
    }

    private static void LogUIPanel(Transform root, string path)
    {
        foreach (Transform trs in root)
        {
            UIPanel panel = trs.GetComponent<UIPanel>();
            if (panel != null)
            {
                Debug.LogError(path + "/" + trs.name);
            }
            LogUIPanel(trs, path + "/" + trs.name);
        }
    }
}