using UnityEngine;
using System.Collections;
using LuaInterface;
using System;

public class LuaManager : MonoBehaviour
{
    private LuaState lua;
    private LuaLooper loop = null;

    void Awake()
    {
        lua = new LuaState();
        OpenLibs();
        lua.LuaSetTop(0);

        LuaBinder.Bind(lua);
        DelegateFactory.Init();
        LuaCoroutine.Register(lua, this);

        Init();
    }

    void Init()
    {
        InitLuaPath();
        lua.Start();
        StartLooper();
    }

    void StartLooper()
    {
        loop = gameObject.AddComponent<LuaLooper>();
        loop.luaState = lua;
    }

    //cjson 比较特殊，只new了一个table，没有注册库，这里注册一下
    protected void OpenCJson()
    {
        lua.LuaGetField(LuaIndexes.LUA_REGISTRYINDEX, "_LOADED");
        lua.OpenLibs(LuaDLL.luaopen_cjson);
        lua.LuaSetField(-2, "cjson");

        lua.OpenLibs(LuaDLL.luaopen_cjson_safe);
        lua.LuaSetField(-2, "cjson.safe");
    }

    #region luaide 调试库添加
    //如果项目中没有luasocket 请打开
    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int LuaOpen_Socket_Core(IntPtr L)
    {
        return LuaDLL.luaopen_socket_core(L);
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int LuaOpen_Mime_Core(IntPtr L)
    {
        return LuaDLL.luaopen_mime_core(L);
    }

    protected void OpenLuaSocket()
    {
        LuaConst.openLuaSocket = true;
        lua.BeginPreLoad();
        lua.RegFunction("socket.core", LuaOpen_Socket_Core);
        lua.RegFunction("mime.core", LuaOpen_Mime_Core);
        lua.EndPreLoad();
    }
    #endregion

    /// <summary>
    /// 程序控制权，转到lua
    /// </summary>
    public void StartMain()
    {
        lua.DoFile("GameStart.lua");

        LuaFunction main = lua.GetFunction("Start");
        main.Call();
        main.Dispose();
        main = null;
    }

    /// <summary>
    /// 初始化加载第三方库
    /// </summary>
    void OpenLibs()
    {
        lua.OpenLibs(LuaDLL.luaopen_pb);
        lua.OpenLibs(LuaDLL.luaopen_lpeg);
        lua.OpenLibs(LuaDLL.luaopen_bit);

        lua.OpenLibs(LuaDLL.luaopen_socket_core);
        OpenLuaSocket();

        OpenCJson();
    }

    /// <summary>
    /// 初始化Lua代码加载路径
    /// </summary>
    void InitLuaPath()
    {
        string rootPath = Application.dataPath;
        lua.AddSearchPath(rootPath + "/Lua");
        lua.AddSearchPath(rootPath + "/ToLua/Lua");
    }

    public void DoFile(string filename)
    {
        lua.DoFile(filename);
    }

    public void LuaGC()
    {
        lua.LuaGC(LuaGCOptions.LUA_GCCOLLECT);
    }

    public void Close()
    {
        loop.Destroy();
        loop = null;

        lua.Dispose();
        lua = null;
    }
}