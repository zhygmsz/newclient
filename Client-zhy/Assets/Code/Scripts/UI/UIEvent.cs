using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEvent : MonoBehaviour
{
    public int mUIID;
    public Collider mCollider;

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
