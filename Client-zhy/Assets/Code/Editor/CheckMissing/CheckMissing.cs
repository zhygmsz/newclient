using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using YamlParser;

public class CheckMissing
{
    [MenuItem("引用检查/列出所有的脚本引用丢失信息")]
    public static void FindAllScriptMissing()
    {
        List<string> scriptList = new List<string>() { "*.cs.meta", "*.js.meta" };
        HashSet<string> guidSet = GetGUIDSet(scriptList);

        List<string> prefabAndUnityList = new List<string>();
        prefabAndUnityList.AddRange(GetFiles("Assets", "*.prefab"));
        prefabAndUnityList.AddRange(GetFiles("Assets", "*.unity"));
        foreach (string path in prefabAndUnityList)
        {
            DoFindScriptMissing(path, guidSet);
        }
    }

    [MenuItem("Assets/引用检查/列出脚本引用丢失信息")]
    public static void FindSelectedScriptMissing()
    {
        string path;
        if (!CheckCommon(out path))
        {
            return;
        }

        List<string> scriptList = new List<string>() { "*.cs.meta", "*.js.meta" };
        HashSet<string> guidSet = GetGUIDSet(scriptList);

        DoFindScriptMissing(path, guidSet);
    }

    [MenuItem("引用检查/列出所有的材质引用丢失信息")]
    public static void FindAllMatMising()
    {
        List<string> matList = new List<string>() { "*.mat.meta" };
        HashSet<string> guidSet = GetGUIDSet(matList);

        List<string> prefabAndUnityList = new List<string>();
        prefabAndUnityList.AddRange(GetFiles("Assets", "*.prefab"));
        prefabAndUnityList.AddRange(GetFiles("Assets", "*.unity"));
        foreach (string path in prefabAndUnityList)
        {
            DoFindMatMissing(path, guidSet);
        }
    }

    [MenuItem("Assets/引用检查/列出材质引用丢失信息")]
    public static void FindSelectedMatMissing()
    {
        string path;
        if (!CheckCommon(out path))
        {
            return;
        }

        List<string> matList = new List<string>() { "*.mat.meta" };
        HashSet<string> guidSet = GetGUIDSet(matList);

        DoFindMatMissing(path, guidSet);
    }

    private static void DoFindScriptMissing(string path, HashSet<string> guidSet)
    {
        ParserBase parserBase = new ParserBase(path);
        parserBase.LogScriptMissing(guidSet);
    }

    private static void DoFindMatMissing(string path, HashSet<string> guidSet)
    {
        ParserBase parserBase = new ParserBase(path);
        parserBase.LogMatMissing(guidSet);
    }

    private static HashSet<string> GetGUIDSet(List<string> suffixList)
    {
        HashSet<string> guidSet = new HashSet<string>();
        List<string> metaList = new List<string>();
        foreach (string suffix in suffixList)
        {
            metaList.AddRange(GetFiles("Assets", suffix));
        }

        for (int idx = 0, count = metaList.Count; idx < count; ++idx)
        {
            FileStream fs = new FileStream(metaList[idx], FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            string guid = sr.ReadLine().Replace(" ", "").Split(':')[1];
            guidSet.Add(guid);
        }

        return guidSet;
    }

    private static bool CheckCommon(out string path)
    {
        path = "";
        bool legal = true;

        do
        {
            if (!CheckIsTextMode())
            {
                legal = false;
                break;
            }

            UnityEngine.Object obj = Selection.activeObject;
            if (obj == null)
            {
                legal = false;
                break;
            }

            path = AssetDatabase.GetAssetPath(obj);
            List<string> suffixNameList = new List<string>() { ".prefab", ".unity" };
            if (!CheckSuffixName(path, suffixNameList))
            {
                legal = false;
                break;
            }
        }
        while (false);

        return legal;
    }

    private static string[] GetFiles(string path, string pattern)
    {
        if (File.Exists(path))
        {
            return new string[] { path };
        }
        else
        {
            return Directory.GetFiles(path, pattern, SearchOption.AllDirectories);
        }
    }

    private static bool CheckSuffixName(string path, List<string> suffixNameList)
    {
        string suffixName = Path.GetExtension(path);
        bool legal = suffixNameList.Contains(suffixName);
        if (!legal)
        {
            EditorUtility.DisplayDialog("提示", "当前选中资源类型不符合，只支持" + string.Join(",", suffixNameList.ToArray()), "确定");
        }
        return legal;
    }

    private static bool CheckIsTextMode()
    {
        if (EditorSettings.serializationMode == SerializationMode.ForceText)
        {
            return true;
        }
        else
        {
            EditorUtility.DisplayDialog("提示", "当前不是文本格式，无法继续，请先转换为文本格式再尝试", "确定");
            return false;
        }

    }
}
