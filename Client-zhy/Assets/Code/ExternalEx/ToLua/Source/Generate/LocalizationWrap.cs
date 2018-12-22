﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LocalizationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Localization");
		L.RegFunction("Load", Load);
		L.RegFunction("Set", Set);
		L.RegFunction("ReplaceKey", ReplaceKey);
		L.RegFunction("ClearReplacements", ClearReplacements);
		L.RegFunction("LoadCSV", LoadCSV);
		L.RegFunction("Get", Get);
		L.RegFunction("Format", Format);
		L.RegFunction("Exists", Exists);
		L.RegVar("loadFunction", get_loadFunction, set_loadFunction);
		L.RegVar("onLocalize", get_onLocalize, set_onLocalize);
		L.RegVar("localizationHasBeenSet", get_localizationHasBeenSet, set_localizationHasBeenSet);
		L.RegVar("dictionary", get_dictionary, set_dictionary);
		L.RegVar("knownLanguages", get_knownLanguages, null);
		L.RegVar("language", get_language, set_language);
		L.RegFunction("OnLocalizeNotification", Localization_OnLocalizeNotification);
		L.RegFunction("LoadFunction", Localization_LoadFunction);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Load(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.TextAsset arg0 = (UnityEngine.TextAsset)ToLua.CheckObject<UnityEngine.TextAsset>(L, 1);
			Localization.Load(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Set(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<string>(L, 2))
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				Localization.Set(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<System.Collections.Generic.Dictionary<string,string>>(L, 2))
			{
				string arg0 = ToLua.CheckString(L, 1);
				System.Collections.Generic.Dictionary<string,string> arg1 = (System.Collections.Generic.Dictionary<string,string>)ToLua.ToObject(L, 2);
				Localization.Set(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<byte[]>(L, 2))
			{
				string arg0 = ToLua.CheckString(L, 1);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 2);
				Localization.Set(arg0, arg1);
				return 0;
			}
			else if (count == 3)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				string arg2 = ToLua.CheckString(L, 3);
				Localization.Set(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Localization.Set");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReplaceKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			Localization.ReplaceKey(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearReplacements(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			Localization.ClearReplacements();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadCSV(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<byte[]>(L, 1))
			{
				byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
				bool o = Localization.LoadCSV(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<UnityEngine.TextAsset>(L, 1))
			{
				UnityEngine.TextAsset arg0 = (UnityEngine.TextAsset)ToLua.ToObject(L, 1);
				bool o = Localization.LoadCSV(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.TextAsset, bool>(L, 1))
			{
				UnityEngine.TextAsset arg0 = (UnityEngine.TextAsset)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				bool o = Localization.LoadCSV(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<byte[], bool>(L, 1))
			{
				byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				bool o = Localization.LoadCSV(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Localization.LoadCSV");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Get(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = Localization.Get(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Format(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			string arg0 = ToLua.CheckString(L, 1);
			object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
			string o = Localization.Format(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Exists(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = Localization.Exists(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loadFunction(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Localization.loadFunction);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onLocalize(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Localization.onLocalize);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localizationHasBeenSet(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, Localization.localizationHasBeenSet);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dictionary(IntPtr L)
	{
		try
		{
			ToLua.PushSealed(L, Localization.dictionary);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_knownLanguages(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Localization.knownLanguages);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_language(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Localization.language);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_loadFunction(IntPtr L)
	{
		try
		{
			Localization.LoadFunction arg0 = (Localization.LoadFunction)ToLua.CheckDelegate<Localization.LoadFunction>(L, 2);
			Localization.loadFunction = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onLocalize(IntPtr L)
	{
		try
		{
			Localization.OnLocalizeNotification arg0 = (Localization.OnLocalizeNotification)ToLua.CheckDelegate<Localization.OnLocalizeNotification>(L, 2);
			Localization.onLocalize = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localizationHasBeenSet(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			Localization.localizationHasBeenSet = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dictionary(IntPtr L)
	{
		try
		{
			System.Collections.Generic.Dictionary<string,string[]> arg0 = (System.Collections.Generic.Dictionary<string,string[]>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,string[]>));
			Localization.dictionary = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_language(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			Localization.language = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Localization_OnLocalizeNotification(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<Localization.OnLocalizeNotification>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<Localization.OnLocalizeNotification>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Localization_LoadFunction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<Localization.LoadFunction>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<Localization.LoadFunction>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

