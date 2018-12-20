using System.Collections;
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
        UIPanel panel = root.GetComponent<UIPanel>();
        if (panel != null)
        {
            Debug.LogError(path);
        }
        foreach (Transform trs in root)
        {
            LogUIPanel(trs, path + "/" + trs.name);
        }
    }

    [MenuItem("程序专用/重新导入UI_Res目录下的图片资源")]
    public static void ReimportAllUITexture()
    {
        string[] paths = CheckMissing.GetFiles("Assets/Res/UI", "*.png");
        for (int idx = 0, len = paths.Length; idx < len; ++idx)
        {
            string path = paths[idx];
            var texImp = TextureImporter.GetAtPath(path);
            if (texImp != null)
            {
                AssetDatabase.ImportAsset(path);
            }
            //EditorUtility.DisplayProgressBar("请稍后", "重设UI图片资源格式", (idx + 1) / len);
        }
    }
}