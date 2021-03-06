﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameCore
{
    //非继承自MonoBehaviour
    public class UIFrame
    {
        private enum UIState
        {
            None = 0,
            OnCreate = 1,
            OnEnable = 2,
            OnDisable = 3,
            OnDestroy = 4,
        }


        private int mUIID;
        private string mUIName;

        private Transform mCachedTrs;
        private GameObject mCachedGo;

        public int UIID
        {
            get
            {
                return mUIID;
            }
        }

        public UIFrame(int uiID, string uiName)
        {
            mUIID = uiID;
            mUIName = uiName;
        }

        public void OnShow()
        {
            //先同步加载UI，并实例化
            //给mCachedTrs,mCachedGo赋值
            string uiPath = AppConst.UIPrefabPath + mUIName + ".prefab";
            GameObject obj = AssetDatabase.LoadAssetAtPath(uiPath, typeof(GameObject)) as GameObject;
            GameObject go = GameObject.Instantiate<GameObject>(obj);
            go.name = mUIName;
            go.transform.parent = UIMgr.UIRootTrsansform;
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            go.transform.localRotation = Quaternion.identity;

            mCachedTrs = go.transform;
            mCachedGo = go;

            //获取所有UIEvent，并设置其UIID为当前UIFrame的
            var uiEvents = go.GetComponentsInChildren<UIEvent>();
            for (int idx = 0, count = uiEvents.Length; idx < count; ++idx)
            {
                uiEvents[idx].UIID = UIID;
            }

            UIMgr.OnCreate(this);
            UIMgr.OnEnable(this);
        }

        public void OnUnShow()
        {
            //只是调用GameObject.SetActive
        }

        //在创建UI时，获取UIEvent脚本数组，把UIEvent.UIID设置成该UIFrame对应的
        //这样，在UIEvent里可以根据uiid去掉用UIMgr的事件方法

        //在UIFrame里处理UI关联的资源细节，以及和资源管理的对接

        //UI的预处理和后处理，都需要在这里做

        //对外保证四个大状态

        //提供两个Find，FindConponent，DuplicateAndAdd三个方法

        public Transform Find(string path)
        {
            return mCachedTrs.Find(path);
        }

        public Component FindComponent(string comName, string path)
        {
            Transform trs = mCachedTrs.Find(path);
            if (trs != null)
            {
                return trs.GetComponent(comName);
            }
            else
            {
                return null;
            }
        }

        public Transform DuplicateAndAdd(Transform prefab, Transform parent, int eventID)
        {
            Transform trs = GameObject.Instantiate(prefab, parent, true);
            //处理trs的UIEvent
            //如果prefab上有多层结构，多个UIEvent时，该如何处理eventID
            return trs;
        }
    }
}