using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameCore
{
    public class UIEvent : MonoBehaviour
    {
        //由面板赋值
        public int mEventID;

        //由UIFrame创建时，赋值
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
            UIMgr.OnClick(UIID, mEventID);
        }

        void OnPress(bool isPressed)
        {
            UIMgr.OnPress(UIID, isPressed, mEventID);
        }

        void OnSelect(bool selected)
        {
            UIMgr.OnSelect(UIID, selected, mEventID);
        }

        void OnDoubleClick()
        {
            UIMgr.OnDoubleClick(UIID, mEventID);
        }

        void OnDragStart()
        {
            UIMgr.OnDragStart(UIID, mEventID);
        }

        void OnDrag(Vector2 delta)
        {
            UIMgr.OnDrag(UIID, delta, mEventID);
        }

        void OnDragEnd()
        {
            UIMgr.OnDragEnd(UIID, mEventID);
        }

        void OnDragOver(GameObject obj)
        {
            UIMgr.OnDragOver(UIID, obj, mEventID);
        }

        void OnDragOut(GameObject obj)
        {
            UIMgr.OnDragOut(UIID, obj, mEventID);
        }
    }

}