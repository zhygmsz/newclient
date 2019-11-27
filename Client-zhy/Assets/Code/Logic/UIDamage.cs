using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDamage : MonoBehaviour
{
    private MeshFilter mMeshFilter;
    private Mesh mMesh;

    // mesh数据
    // 最大数字数量，正负号，暴击，背景灯都算一个数字
    private const int MAXNUMBE = 500;
    private int[] mVertices = new int[MAXNUMBE * 4];

    private void Awake()
    {
        mMeshFilter = GetComponent<MeshFilter>();
        if (mMeshFilter == null)
        {
            Debug.LogError("miss MeshFilter");
            return;
        }

        InitMesh();
    }

    private void InitMesh()
    {
        mMesh = new Mesh();
        mMesh.MarkDynamic();
        mMeshFilter.mesh = mMesh;
    }
    
}
