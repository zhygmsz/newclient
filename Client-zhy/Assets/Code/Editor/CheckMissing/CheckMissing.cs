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

    }

    [MenuItem("Assets/引用检查/列出脚本引用丢失信息")]
    public static void FindSelectedScriptMissing()
    {
        //检测当前编辑器资源序列化格式
        if (!CheckIsTextMode())
        {
            return;
        }

        UnityEngine.Object obj = Selection.activeObject;
        if (obj == null)
        {
            return;
        }

        string path = AssetDatabase.GetAssetPath(obj);
        List<string> suffixNameList = new List<string>() { ".prefab", ".unity" };
        if (!CheckSuffixName(path, suffixNameList))
        {
            return;
        }

        HashSet<string> guidSet = GetGUIDSet();
        ParserBase parserBase = new ParserBase(path);
        parserBase.LogScriptMissing(guidSet);
    }

    private static HashSet<string> GetGUIDSet()
    {
        HashSet<string> guidSet = new HashSet<string>();
        List<string> css = new List<string>();
        css.AddRange(GetFiles("Assets", "*.cs.meta"));
        css.AddRange(GetFiles("Assets", "*.js.meta"));

        for (int idx = 0, count = css.Count; idx < count; ++idx)
        {
            FileStream fs = new FileStream(css[idx], FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            string guid = sr.ReadLine().Replace(" ", "").Split(':')[1];
            guidSet.Add(guid);
        }

        return guidSet;
    }

    private static void DoFindScriptMissing(string path, HashSet<string> guidSet)
    {

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
