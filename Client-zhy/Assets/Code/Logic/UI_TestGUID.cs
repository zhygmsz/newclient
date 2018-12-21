using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_TestGUID : MonoBehaviour
{


    private void Awake()
    {
        GameObject goC = transform.Find("A/B/C").gameObject;
        GameObject goA = transform.Find("A").gameObject;
        UIPanel panel = goC.GetComponentInParent<UIPanel>();
        UIPanel panel2 = goC.transform.parent.GetComponent<UIPanel>();
        UIPanel panel3 = goA.GetComponentInChildren<UIPanel>();
        UIPanel[] panel4 = goA.GetComponentsInChildren<UIPanel>();
        UIPanel[] panel5 = goC.GetComponentsInParent<UIPanel>();
        int val = 1;
    }

    private void Start()
    {
        
    }


}
