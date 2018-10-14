using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;

public class UIMgr
{
    //ShowUI，UnShowUI方法接受的uiid，通过该字典查询对应的UIFrame
    //处理UI打开对于其他界面的互斥逻辑时，也需要对所有UI有一个统筹
    //所有该UIMgr里的方法，但凡传进来的参数是uiid，则都需要该字典
    static private Dictionary<int, UIFrame> mUIFrameDic = new Dictionary<int, UIFrame>();

    //UIFrame的UI状态事件方法
    static private LuaFunction mOnCreate;
    static private LuaFunction mOnEnable;
    static private LuaFunction mOnDisable;
    static private LuaFunction mOnDestroy;

    //NGUI事件方法
    static private LuaFunction mOnClick;
    static private LuaFunction mOnPress;
    static private LuaFunction mOnSelect;

    static private LuaFunction mOnDoubleClick;

    static private LuaFunction mOnDragStart;
    static private LuaFunction mOnDrag;
    static private LuaFunction mOnDragEnd;
    static private LuaFunction mOnDragOver;
    static private LuaFunction mOnDragOut;

    static public void Init(
        LuaFunction onCreate, LuaFunction onEnable, LuaFunction onDisable, LuaFunction onDestroy, 
        LuaFunction onClick, LuaFunction onPress, LuaFunction onSelect,
        LuaFunction onDoubleClick,
        LuaFunction onDragStart, LuaFunction onDrag, LuaFunction onDragEnd, LuaFunction onDragOver, LuaFunction onDragOut)
    {
        mOnCreate = onCreate;
        mOnEnable = onEnable;
        mOnDisable = onDisable;
        mOnDestroy = onDestroy;

        mOnClick = onClick;
        mOnPress = onPress;
        mOnSelect = onSelect;

        mOnDoubleClick = onDoubleClick;

        mOnDragStart = onDragStart;
        mOnDrag = onDrag;
        mOnDragEnd = onDragEnd;
        mOnDragOver = onDragOver;
        mOnDragOut = onDragOut;
    }

    //下面两个方法调度UIFrame
    //UI关联的资源处理细节放到UIFrame里做
    static public void ShowUI(int uiID, string uiPath)
	{
        UIFrame frame = null;
        if (!mUIFrameDic.TryGetValue(uiID, out frame))
        {
            frame = new UIFrame(uiID, uiPath);
            mUIFrameDic[uiID] = frame;
        }

        frame.OnShow();
	}

	static public void UnShowUI(int uiID)
	{
        UIFrame frame = null;
        if (mUIFrameDic.TryGetValue(uiID, out frame))
        {
            frame.OnUnShow();
        }
	}

	//下面的方法是，UI的状态回调，由UIFrame发起
	//在这里做转发，传递给lua层
	//lua层再根据uiid派发给各个UI对应的lua脚本
	static public void OnCreate(UIFrame frame)
	{

	}

	static public void OnEnable(UIFrame frame)
	{

	}

	static public void OnDisable(UIFrame frame)
	{

	}

	static public void OnDestroy(UIFrame frame)
	{

	}

	//下面的方法是各种UI事件方法，由UIEvent调用，直接传递到lua层
	//在UIMgr里接受lua注册进来的各种UI事件的方法，不同的界面以uiid来区分
	//在lua层根据uiid再做一次派发，直到每个UI事件传递到UI对应的lua脚本里
	static public void OnClick(int uiID)
	{

	}

	static public void OnPress(int uiID, bool isPressed)
	{

	}

    static public void OnSelect(int uiID, bool selected)
    {

    }

    static public void OnDoubleClick(int uiID)
    {

    }

    static public void OnDragStart(int uiID)
    {

    }

	static public void OnDrag(int uiID, Vector2 delta)
	{
		
	}

    static public void OnDragEnd(int uiID)
    {

    }

    static public void OnDragOver(int uiID, GameObject obj)
    {

    }

    static public void OnDragOut(int uiID, GameObject obj)
    {

    }
}
