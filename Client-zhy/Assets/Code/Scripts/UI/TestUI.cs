using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI : MonoBehaviour
{
    //组件
    private GameObject mSpGo1;
    private GameObject mSpGo2;
    private int mIndex = 0;

    private float mTimer = 0f;
    private float mThreshold = 5f;

    private void Awake()
    {
        mSpGo1 = transform.Find("sp11111").gameObject;
        mSpGo2 = transform.Find("sp22222").gameObject;

        //绑定事件
        UIEventListener.Get(mSpGo1).onClick = OnClickSp;
        UIEventListener.Get(mSpGo1).onDoubleClick = OnDoubleClickSp;
        UIEventListener.Get(mSpGo1).onHover = OnHoverSp;
        UIEventListener.Get(mSpGo1).onPress = OnPressSp;
        UIEventListener.Get(mSpGo1).onLongPress = OnLongPressSp;
        UIEventListener.Get(mSpGo1).onDragStart = OnDragStartSp;
        UIEventListener.Get(mSpGo1).onDrag = OnDragSp;
        UIEventListener.Get(mSpGo1).onDragOver = OnDragOverSp;
        UIEventListener.Get(mSpGo1).onDragOut = OnDragOutSp;
        UIEventListener.Get(mSpGo1).onDragEnd = OnDragEndSp;
        UIEventListener.Get(mSpGo1).onDrop = OnDropSp;

        //2
        UIEventListener.Get(mSpGo2).onClick = OnClickSp;
        UIEventListener.Get(mSpGo2).onDoubleClick = OnDoubleClickSp;
        UIEventListener.Get(mSpGo2).onHover = OnHoverSp;
        UIEventListener.Get(mSpGo2).onPress = OnPressSp;
        UIEventListener.Get(mSpGo2).onLongPress = OnLongPressSp;
        UIEventListener.Get(mSpGo2).onDragStart = OnDragStartSp;
        UIEventListener.Get(mSpGo2).onDrag = OnDragSp;
        UIEventListener.Get(mSpGo2).onDragOver = OnDragOverSp;
        UIEventListener.Get(mSpGo2).onDragOut = OnDragOutSp;
        UIEventListener.Get(mSpGo2).onDragEnd = OnDragEndSp;
        UIEventListener.Get(mSpGo2).onDrop = OnDropSp;
    }

    private void Start()
    {

    }

    //打印UICamera.currentTouch.current
    private void CheckAndLogCurrent()
    {
        if (UICamera.currentTouch != null)
        {
            GameObject cur = UICamera.currentTouch.current;
            if (cur != null)
            {
                string str = string.Format("------------------------------------------------cur.name = {0}", cur.name);
                Debug.LogError(str);
            }
        }
    }

    private void Update()
    {
        mTimer += Time.deltaTime;
        if (mTimer >= mThreshold)
        {
            mTimer = 0f;

            //do
            CheckAndLogCurrent();
        }
    }

    private int GetIndex()
    {
        mIndex += 1;
        return mIndex;
    }

    //回调
    private void OnClickSp(GameObject go)
    {
        string str = string.Format("-------------------------------OnClickSp -> goName = {0}, {1}", go.name, GetIndex());
        Debug.LogError("-------------------------------OnClickSp -> " + GetIndex());
    }

    private void OnPressSp(GameObject go, bool pressed)
    {
        string str = string.Format("-------------------------------OnPressSp -> goName = {0}, pressed = {1}, {2}",go.name, pressed, GetIndex());
        //Debug.LogError(str);
    }

    private void OnLongPressSp(GameObject go)
    {
        string str = string.Format("-------------------------------OnLongPressSp -> goName = {0}, {1}", go.name, GetIndex());
        Debug.LogError(str);
    }

    private void OnDoubleClickSp(GameObject go)
    {
        //Debug.LogError("-------------------------------OnDoubleClickSp -> " + GetIndex());
    }

    private void OnHoverSp(GameObject go, bool isOver)
    {
        string str = string.Format("-------------------------------OnHoverSp -> isOver = {0}, {1}", isOver, GetIndex());
        //Debug.LogError(str);
    }

    private void OnDragStartSp(GameObject go)
    {
        //Debug.LogError("-------------------------------OnDragStartSp -> " + GetIndex());
    }

    private void OnDragSp(GameObject go, Vector2 delta)
    {
        string str = string.Format("-------------------------------OnDragSp -> delta = [{0}, {1}], {2}", delta.x, delta.y, GetIndex());
        //Debug.LogError(str);
    }

    private void OnDragOverSp(GameObject go)
    {
        //Debug.LogError("-------------------------------OnDragOverSp -> " + GetIndex());
    }

    private void OnDragOutSp(GameObject go)
    {
        //Debug.LogError("-------------------------------OnDragOutSp -> " + GetIndex());
    }

    private void OnDragEndSp(GameObject go)
    {
        //Debug.LogError("-------------------------------OnDragEndSp -> " + GetIndex());
    }

    private void OnDropSp(GameObject go, GameObject obj)
    {
        string str = string.Format("-------------------------------OnDropSp -> obj'name = {0}, {1}", obj.name, GetIndex());
        //Debug.LogError(str);
    }
}
