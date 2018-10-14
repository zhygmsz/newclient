using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEvent : MonoBehaviour
{
    private int mUIID;
    private Collider mCollider;

	public int UIID
	{
		get
		{
            return mUIID;
        }
		set
		{
            mUIID = value;
        }
	}

	void Awake()
	{
        mCollider = GetComponent<BoxCollider>();
    }

	void OnClick()
	{
        UIMgr.OnClick(UIID);
	}

	void OnPress(bool isPressed)
	{
        UIMgr.OnPress(UIID, isPressed);
	}

    void OnSelect(bool selected)
    {
        UIMgr.OnSelect(UIID, selected);
    }

    void OnDoubleClick()
    {
        UIMgr.OnDoubleClick(UIID);
    }

    void OnDragStart()
    {
        UIMgr.OnDragStart(UIID);
    }

	void OnDrag(Vector2 delta)
	{
        UIMgr.OnDrag(UIID, delta);
	}

    void OnDragEnd()
    {
        UIMgr.OnDragEnd(UIID);
    }

    void OnDragOver(GameObject obj)
    {
        UIMgr.OnDragOver(UIID, obj);
    }

    void OnDragOut(GameObject obj)
    {
        UIMgr.OnDragOut(UIID, obj);
    }
}
