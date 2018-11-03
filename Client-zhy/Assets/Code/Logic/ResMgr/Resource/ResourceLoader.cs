using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameCore.Res
{
	//只负责资源的加载，与实例化
	//加载策略在这里处理，比如加载优先级队列等
	//该类定义加载器的抽象接口，具体实现由Editor和Bundle两个平台去实现
	//但提供的接口与保证的行为是一致的
	//保证在Editor开发模式下运行正常的接口在Bundle模式下也应该是正常的
    public class ResourceLoader
    {

    }
}
