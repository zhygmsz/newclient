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
		
	}

	void OnPress(bool isPressed)
	{

	}

	void OnDrag(Vector2 delta)
	{
		
	}
}
