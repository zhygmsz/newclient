using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr
{
    static private Dictionary<int, UIFrame> mUIDic = new Dictionary<int, UIFrame>();

	//下面两个方法调度UIFrame
	//UI关联的资源处理细节放到UIFrame里做
	static public void ShowUI()
	{
		//打开UI时，如果不存在
	}

	static public void UnShowUI()
	{

	}

	//下面的方法是，UI的状态回调，由UIFrame发起
	//在这里做转发，传递给lua层
	//lua层再根据uiid派发给各个UI对应的lua脚本
	static public void OnCreate()
	{

	}

	static public void OnEnable()
	{

	}

	static public void OnDisable()
	{

	}

	static public void OnDestroy()
	{

	}

	//下面的方法是各种UI事件方法，由UIEvent调用，直接传递到lua层
	//在UIMgr里接受lua注册进来的各种UI事件的方法，不同的界面以uiid来区分
	//在lua层根据uiid再做一次派发，直到每个UI事件传递到UI对应的lua脚本里
	static public void OnClick(int uiid)
	{

	}

	static public void OnPress(int uiid, bool isPressed)
	{

	}

	static public void OnDrag(int uiid, Vector2 delta)
	{
		
	}
}
