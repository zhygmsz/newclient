using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UIAutoScale : MonoBehaviour
{
    public UIRoot mRoot;
    public Transform mTransform;

    private void Start()
    {
        mTransform = transform;
        mRoot = NGUITools.FindInParents<UIRoot>(mTransform);
    }

    private void Update()
    {
        if(mTransform != null && mRoot != null)
        {
            UpdateScale();
        }
    }

    private void UpdateScale()
    {
        int activeHeight = mRoot.activeHeight;
        float size = activeHeight != mRoot.manualHeight ? (float)activeHeight / mRoot.manualHeight : 1f;
        Vector3 ls = mTransform.localScale;
        if(!(Mathf.Abs(ls.x - size) <= float.Epsilon) || !(Mathf.Abs(ls.y - size) <= float.Epsilon) || !(Mathf.Abs(ls.z - size) <= float.Epsilon))
        {
            mTransform.localScale = new Vector3(size, size, size);
        }
    }
}
