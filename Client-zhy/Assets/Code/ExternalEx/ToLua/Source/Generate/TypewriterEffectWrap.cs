﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TypewriterEffectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TypewriterEffect), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("ResetToBeginning", ResetToBeginning);
		L.RegFunction("Finish", Finish);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("current", get_current, set_current);
		L.RegVar("charsPerSecond", get_charsPerSecond, set_charsPerSecond);
		L.RegVar("fadeInTime", get_fadeInTime, set_fadeInTime);
		L.RegVar("delayOnPeriod", get_delayOnPeriod, set_delayOnPeriod);
		L.RegVar("delayOnNewLine", get_delayOnNewLine, set_delayOnNewLine);
		L.RegVar("scrollView", get_scrollView, set_scrollView);
		L.RegVar("keepFullDimensions", get_keepFullDimensions, set_keepFullDimensions);
		L.RegVar("onFinished", get_onFinished, set_onFinished);
		L.RegVar("isActive", get_isActive, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetToBeginning(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TypewriterEffect obj = (TypewriterEffect)ToLua.CheckObject<TypewriterEffect>(L, 1);
			obj.ResetToBeginning();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Finish(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TypewriterEffect obj = (TypewriterEffect)ToLua.CheckObject<TypewriterEffect>(L, 1);
			obj.Finish();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_current(IntPtr L)
	{
		try
		{
			ToLua.Push(L, TypewriterEffect.current);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_charsPerSecond(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			int ret = obj.charsPerSecond;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index charsPerSecond on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fadeInTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			float ret = obj.fadeInTime;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fadeInTime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_delayOnPeriod(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			float ret = obj.delayOnPeriod;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index delayOnPeriod on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_delayOnNewLine(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			float ret = obj.delayOnNewLine;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index delayOnNewLine on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scrollView(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			UIScrollView ret = obj.scrollView;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollView on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_keepFullDimensions(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			bool ret = obj.keepFullDimensions;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index keepFullDimensions on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onFinished(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			System.Collections.Generic.List<EventDelegate> ret = obj.onFinished;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onFinished on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isActive(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			bool ret = obj.isActive;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isActive on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_current(IntPtr L)
	{
		try
		{
			TypewriterEffect arg0 = (TypewriterEffect)ToLua.CheckObject<TypewriterEffect>(L, 2);
			TypewriterEffect.current = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_charsPerSecond(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.charsPerSecond = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index charsPerSecond on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fadeInTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.fadeInTime = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fadeInTime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_delayOnPeriod(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.delayOnPeriod = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index delayOnPeriod on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_delayOnNewLine(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.delayOnNewLine = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index delayOnNewLine on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scrollView(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			UIScrollView arg0 = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 2);
			obj.scrollView = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollView on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_keepFullDimensions(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.keepFullDimensions = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index keepFullDimensions on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onFinished(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TypewriterEffect obj = (TypewriterEffect)o;
			System.Collections.Generic.List<EventDelegate> arg0 = (System.Collections.Generic.List<EventDelegate>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
			obj.onFinished = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onFinished on a nil value");
		}
	}
}

