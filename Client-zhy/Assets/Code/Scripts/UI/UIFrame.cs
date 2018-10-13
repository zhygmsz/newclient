using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//非继承自MonoBehaviour
public class UIFrame
{
	//在创建UI时，获取UIEvent脚本数组，把UIEvent.UIID设置成该UIFrame对应的
    //这样，在UIEvent里可以根据uiid去掉用UIMgr的事件方法

    //在UIFrame里处理UI关联的资源细节，以及和资源管理的对接

    //UI的预处理和后处理，都需要在这里做

    //对外保证四个大状态

}