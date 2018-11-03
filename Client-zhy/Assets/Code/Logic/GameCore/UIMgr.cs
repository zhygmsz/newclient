using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;

//某些C#类，用于对lua提供服务，可能Lua层也有一份相同类名的.
//这时，就需要把C#类定义在该名空间下
namespace GameCore
{
    public class UIMgr
    {
        static private Transform mUIRootTransform;
        static public Transform UIRootTrsansform
        {
            get
            {
                if (mUIRootTransform == null)
                {
                    GameObject obj = GameObject.Find("UI Root");
                    if (obj != null)
                    {
                        mUIRootTransform = obj.transform;    
                    }
                }

                return mUIRootTransform;
            }
        }

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
        static public void ShowUI(int uiID, string uiName)
        {
            Utils.Log("----------------------------ShowUI");
            UIFrame frame = null;
            if (!mUIFrameDic.TryGetValue(uiID, out frame))
            {
                frame = new UIFrame(uiID, uiName);
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
            mOnCreate.BeginPCall();
            mOnCreate.Push(frame.UIID);
            mOnCreate.Push(frame);
            mOnCreate.PCall();
            mOnCreate.EndPCall();
        }

        static public void OnEnable(UIFrame frame)
        {
            mOnEnable.BeginPCall();
            mOnEnable.Push(frame.UIID);
            mOnEnable.Push(frame);
            mOnEnable.PCall();
            mOnEnable.EndPCall();
        }

        static public void OnDisable(UIFrame frame)
        {
            mOnDisable.BeginPCall();
            mOnDisable.Push(frame.UIID);
            mOnDisable.Push(frame);
            mOnDisable.PCall();
            mOnDisable.EndPCall();
        }

        static public void OnDestroy(UIFrame frame)
        {
            mOnDestroy.BeginPCall();
            mOnDestroy.Push(frame.UIID);
            mOnDestroy.Push(frame);
            mOnDestroy.PCall();
            mOnDestroy.EndPCall();
        }

        //下面的方法是各种UI事件方法，由UIEvent调用，直接传递到lua层
        //在UIMgr里接受lua注册进来的各种UI事件的方法，不同的界面以uiid来区分
        //在lua层根据uiid再做一次派发，直到每个UI事件传递到UI对应的lua脚本里
        static public void OnClick(int uiID, int eventID)
        {
            mOnClick.BeginPCall();
            mOnClick.Push(uiID);
            mOnClick.Push(eventID);
            mOnClick.PCall();
            mOnClick.EndPCall();
        }

        static public void OnPress(int uiID, bool isPressed, int eventID)
        {
            mOnPress.BeginPCall();
            mOnPress.Push(uiID);
            mOnPress.Push(isPressed);
            mOnPress.Push(eventID);
            mOnPress.PCall();
            mOnPress.EndPCall();
        }

        static public void OnSelect(int uiID, bool selected, int eventID)
        {
            mOnSelect.BeginPCall();
            mOnSelect.Push(uiID);
            mOnSelect.Push(selected);
            mOnSelect.Push(eventID);
            mOnSelect.PCall();
            mOnSelect.EndPCall();
        }

        static public void OnDoubleClick(int uiID, int eventID)
        {
            mOnDoubleClick.BeginPCall();
            mOnDoubleClick.Push(uiID);
            mOnDoubleClick.Push(eventID);
            mOnDoubleClick.PCall();
            mOnDoubleClick.EndPCall();
        }

        static public void OnDragStart(int uiID, int eventID)
        {
            mOnDragStart.BeginPCall();
            mOnDragStart.Push(uiID);
            mOnDragStart.Push(eventID);
            mOnDragStart.PCall();
            mOnDragStart.EndPCall();
        }

        static public void OnDrag(int uiID, Vector2 delta, int eventID)
        {
            mOnDrag.BeginPCall();
            mOnDrag.Push(uiID);
            mOnDrag.Push(delta);
            mOnDrag.Push(eventID);
            mOnDrag.PCall();
            mOnDrag.EndPCall();
        }

        static public void OnDragEnd(int uiID, int eventID)
        {
            mOnDragEnd.BeginPCall();
            mOnDragEnd.Push(uiID);
            mOnDragEnd.Push(eventID);
            mOnDragEnd.PCall();
            mOnDragEnd.EndPCall();
        }

        static public void OnDragOver(int uiID, GameObject obj, int eventID)
        {
            mOnDragOver.BeginPCall();
            mOnDragOver.Push(uiID);
            mOnDragOver.Push(obj);
            mOnDragOver.Push(eventID);
            mOnDragOver.PCall();
            mOnDragOver.EndPCall();
        }

        static public void OnDragOut(int uiID, GameObject obj, int eventID)
        {
            mOnDragOut.BeginPCall();
            mOnDragOut.Push(uiID);
            mOnDragOut.Push(obj);
            mOnDragOut.Push(eventID);
            mOnDragOut.PCall();
            mOnDragOut.EndPCall();
        }
    }

}