﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIScrollViewWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIScrollView), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("RestrictWithinBounds", RestrictWithinBounds);
		L.RegFunction("DisableSpring", DisableSpring);
		L.RegFunction("UpdateScrollbars", UpdateScrollbars);
		L.RegFunction("SetDragAmount", SetDragAmount);
		L.RegFunction("InvalidateBounds", InvalidateBounds);
		L.RegFunction("ResetPosition", ResetPosition);
		L.RegFunction("UpdatePosition", UpdatePosition);
		L.RegFunction("OnScrollBar", OnScrollBar);
		L.RegFunction("MoveRelative", MoveRelative);
		L.RegFunction("MoveAbsolute", MoveAbsolute);
		L.RegFunction("Press", Press);
		L.RegFunction("Drag", Drag);
		L.RegFunction("Scroll", Scroll);
		L.RegFunction("OnPan", OnPan);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("list", get_list, set_list);
		L.RegVar("movement", get_movement, set_movement);
		L.RegVar("dragEffect", get_dragEffect, set_dragEffect);
		L.RegVar("restrictWithinPanel", get_restrictWithinPanel, set_restrictWithinPanel);
		L.RegVar("constrainOnDrag", get_constrainOnDrag, set_constrainOnDrag);
		L.RegVar("disableDragIfFits", get_disableDragIfFits, set_disableDragIfFits);
		L.RegVar("smoothDragStart", get_smoothDragStart, set_smoothDragStart);
		L.RegVar("iOSDragEmulation", get_iOSDragEmulation, set_iOSDragEmulation);
		L.RegVar("scrollWheelFactor", get_scrollWheelFactor, set_scrollWheelFactor);
		L.RegVar("momentumAmount", get_momentumAmount, set_momentumAmount);
		L.RegVar("dampenStrength", get_dampenStrength, set_dampenStrength);
		L.RegVar("horizontalScrollBar", get_horizontalScrollBar, set_horizontalScrollBar);
		L.RegVar("verticalScrollBar", get_verticalScrollBar, set_verticalScrollBar);
		L.RegVar("showScrollBars", get_showScrollBars, set_showScrollBars);
		L.RegVar("customMovement", get_customMovement, set_customMovement);
		L.RegVar("contentPivot", get_contentPivot, set_contentPivot);
		L.RegVar("onDragStarted", get_onDragStarted, set_onDragStarted);
		L.RegVar("onDragFinished", get_onDragFinished, set_onDragFinished);
		L.RegVar("onMomentumMove", get_onMomentumMove, set_onMomentumMove);
		L.RegVar("onStoppedMoving", get_onStoppedMoving, set_onStoppedMoving);
		L.RegVar("centerOnChild", get_centerOnChild, set_centerOnChild);
		L.RegVar("panel", get_panel, null);
		L.RegVar("isDragging", get_isDragging, null);
		L.RegVar("bounds", get_bounds, null);
		L.RegVar("canMoveHorizontally", get_canMoveHorizontally, null);
		L.RegVar("canMoveVertically", get_canMoveVertically, null);
		L.RegVar("shouldMoveHorizontally", get_shouldMoveHorizontally, null);
		L.RegVar("shouldMoveVertically", get_shouldMoveVertically, null);
		L.RegVar("currentMomentum", get_currentMomentum, set_currentMomentum);
		L.RegFunction("OnDragNotification", UIScrollView_OnDragNotification);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RestrictWithinBounds(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				bool o = obj.RestrictWithinBounds(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 4)
			{
				UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				bool o = obj.RestrictWithinBounds(arg0, arg1, arg2);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UIScrollView.RestrictWithinBounds");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DisableSpring(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			obj.DisableSpring();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateScrollbars(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
				obj.UpdateScrollbars();
				return 0;
			}
			else if (count == 2)
			{
				UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.UpdateScrollbars(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UIScrollView.UpdateScrollbars");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDragAmount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			obj.SetDragAmount(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InvalidateBounds(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			obj.InvalidateBounds();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			obj.ResetPosition();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdatePosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			obj.UpdatePosition();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnScrollBar(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			obj.OnScrollBar();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveRelative(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.MoveRelative(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveAbsolute(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.MoveAbsolute(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Press(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Press(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Drag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			obj.Drag();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Scroll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Scroll(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPan(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollView obj = (UIScrollView)ToLua.CheckObject<UIScrollView>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.OnPan(arg0);
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
	static int get_list(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, UIScrollView.list);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_movement(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.Movement ret = obj.movement;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index movement on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dragEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.DragEffect ret = obj.dragEffect;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dragEffect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_restrictWithinPanel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.restrictWithinPanel;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index restrictWithinPanel on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_constrainOnDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.constrainOnDrag;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index constrainOnDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_disableDragIfFits(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.disableDragIfFits;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index disableDragIfFits on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_smoothDragStart(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.smoothDragStart;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index smoothDragStart on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_iOSDragEmulation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.iOSDragEmulation;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index iOSDragEmulation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scrollWheelFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			float ret = obj.scrollWheelFactor;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollWheelFactor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_momentumAmount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			float ret = obj.momentumAmount;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index momentumAmount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dampenStrength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			float ret = obj.dampenStrength;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dampenStrength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_horizontalScrollBar(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIProgressBar ret = obj.horizontalScrollBar;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index horizontalScrollBar on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_verticalScrollBar(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIProgressBar ret = obj.verticalScrollBar;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalScrollBar on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_showScrollBars(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.ShowCondition ret = obj.showScrollBars;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index showScrollBars on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_customMovement(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UnityEngine.Vector2 ret = obj.customMovement;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index customMovement on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contentPivot(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIWidget.Pivot ret = obj.contentPivot;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index contentPivot on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDragStarted(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.OnDragNotification ret = obj.onDragStarted;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDragStarted on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDragFinished(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.OnDragNotification ret = obj.onDragFinished;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDragFinished on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onMomentumMove(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.OnDragNotification ret = obj.onMomentumMove;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onMomentumMove on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onStoppedMoving(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.OnDragNotification ret = obj.onStoppedMoving;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onStoppedMoving on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_centerOnChild(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UICenterOnChild ret = obj.centerOnChild;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index centerOnChild on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_panel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIPanel ret = obj.panel;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index panel on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isDragging(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.isDragging;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isDragging on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bounds(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UnityEngine.Bounds ret = obj.bounds;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bounds on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canMoveHorizontally(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.canMoveHorizontally;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index canMoveHorizontally on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canMoveVertically(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.canMoveVertically;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index canMoveVertically on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shouldMoveHorizontally(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.shouldMoveHorizontally;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shouldMoveHorizontally on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shouldMoveVertically(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool ret = obj.shouldMoveVertically;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shouldMoveVertically on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentMomentum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UnityEngine.Vector3 ret = obj.currentMomentum;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index currentMomentum on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_list(IntPtr L)
	{
		try
		{
			BetterList<UIScrollView> arg0 = (BetterList<UIScrollView>)ToLua.CheckObject<BetterList<UIScrollView>>(L, 2);
			UIScrollView.list = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_movement(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.Movement arg0 = (UIScrollView.Movement)ToLua.CheckObject(L, 2, typeof(UIScrollView.Movement));
			obj.movement = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index movement on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dragEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.DragEffect arg0 = (UIScrollView.DragEffect)ToLua.CheckObject(L, 2, typeof(UIScrollView.DragEffect));
			obj.dragEffect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dragEffect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_restrictWithinPanel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.restrictWithinPanel = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index restrictWithinPanel on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_constrainOnDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.constrainOnDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index constrainOnDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_disableDragIfFits(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.disableDragIfFits = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index disableDragIfFits on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_smoothDragStart(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.smoothDragStart = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index smoothDragStart on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_iOSDragEmulation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.iOSDragEmulation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index iOSDragEmulation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scrollWheelFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.scrollWheelFactor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollWheelFactor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_momentumAmount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.momentumAmount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index momentumAmount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dampenStrength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.dampenStrength = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dampenStrength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_horizontalScrollBar(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIProgressBar arg0 = (UIProgressBar)ToLua.CheckObject<UIProgressBar>(L, 2);
			obj.horizontalScrollBar = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index horizontalScrollBar on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_verticalScrollBar(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIProgressBar arg0 = (UIProgressBar)ToLua.CheckObject<UIProgressBar>(L, 2);
			obj.verticalScrollBar = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalScrollBar on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_showScrollBars(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.ShowCondition arg0 = (UIScrollView.ShowCondition)ToLua.CheckObject(L, 2, typeof(UIScrollView.ShowCondition));
			obj.showScrollBars = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index showScrollBars on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_customMovement(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.customMovement = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index customMovement on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_contentPivot(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIWidget.Pivot arg0 = (UIWidget.Pivot)ToLua.CheckObject(L, 2, typeof(UIWidget.Pivot));
			obj.contentPivot = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index contentPivot on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDragStarted(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.OnDragNotification arg0 = (UIScrollView.OnDragNotification)ToLua.CheckDelegate<UIScrollView.OnDragNotification>(L, 2);
			obj.onDragStarted = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDragStarted on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDragFinished(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.OnDragNotification arg0 = (UIScrollView.OnDragNotification)ToLua.CheckDelegate<UIScrollView.OnDragNotification>(L, 2);
			obj.onDragFinished = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDragFinished on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onMomentumMove(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.OnDragNotification arg0 = (UIScrollView.OnDragNotification)ToLua.CheckDelegate<UIScrollView.OnDragNotification>(L, 2);
			obj.onMomentumMove = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onMomentumMove on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onStoppedMoving(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UIScrollView.OnDragNotification arg0 = (UIScrollView.OnDragNotification)ToLua.CheckDelegate<UIScrollView.OnDragNotification>(L, 2);
			obj.onStoppedMoving = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onStoppedMoving on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_centerOnChild(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UICenterOnChild arg0 = (UICenterOnChild)ToLua.CheckObject<UICenterOnChild>(L, 2);
			obj.centerOnChild = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index centerOnChild on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_currentMomentum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollView obj = (UIScrollView)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.currentMomentum = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index currentMomentum on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UIScrollView_OnDragNotification(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UIScrollView.OnDragNotification>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UIScrollView.OnDragNotification>.Create(func, self);
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

