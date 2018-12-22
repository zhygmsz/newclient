using UnityEngine;
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEditor;

using BindType = ToLuaMenu.BindType;
using System.Reflection;

public static class CustomSettings
{
    public static string saveDir = Application.dataPath + "/Code/ExternalEx/ToLua/Source/Generate/";
    public static string toluaBaseType = Application.dataPath + "/Code/External/ToLua/BaseType/";
    public static string baseLuaDir = Application.dataPath + "/Lua/Logic/Framework/ToLua/";
    public static string injectionFilesPath = Application.dataPath + "/Code/External/ToLua/Injection/";

    //导出时强制做为静态类的类型(注意customTypeList 还要添加这个类型才能导出)
    //unity 有些类作为sealed class, 其实完全等价于静态类
    public static List<Type> staticClassTypes = new List<Type>
    {        
        typeof(UnityEngine.Application),
        typeof(UnityEngine.Time),
        typeof(UnityEngine.Screen),
        typeof(UnityEngine.Input),
        //本该删掉它，但目前还没引入ab包为基础的资源管理方案，lua层想用资源只能暂时通过Resources
        typeof(UnityEngine.Resources),
        typeof(UnityEngine.RenderSettings),
        typeof(UnityEngine.QualitySettings),
        typeof(UnityEngine.Graphics),
    };

    //附加导出委托类型(在导出委托时, customTypeList 中牵扯的委托类型都会导出， 无需写在这里)
    public static DelegateType[] customDelegateList = 
    {        
        _DT(typeof(Action)),                
        _DT(typeof(UnityEngine.Events.UnityAction)),
        _DT(typeof(System.Predicate<int>)),
        _DT(typeof(System.Action<int>)),
        _DT(typeof(System.Comparison<int>)),
        _DT(typeof(System.Func<int, int>)),
    };

    //在这里添加你要导出注册到lua的类型列表
    public static BindType[] customTypeList =
    {
        _GT(typeof(LuaInjectionStation)),
        _GT(typeof(InjectType)),
        _GT(typeof(Debugger)).SetNameSpace(null),

        _GT(typeof(Component)),
        _GT(typeof(Transform)),
        _GT(typeof(Material)),
        _GT(typeof(Light)),
        _GT(typeof(Rigidbody)),
        _GT(typeof(Camera)),
        _GT(typeof(AudioSource)),

        _GT(typeof(Behaviour)),
        _GT(typeof(MonoBehaviour)),
        _GT(typeof(GameObject)),
        _GT(typeof(TrackedReference)),
        _GT(typeof(Application)),
        _GT(typeof(Physics)),
        _GT(typeof(Collider)),
        _GT(typeof(Time)),
        _GT(typeof(Texture)),
        _GT(typeof(Texture2D)),
        _GT(typeof(Shader)),
        _GT(typeof(Renderer)),
        _GT(typeof(WWW)),
        _GT(typeof(Screen)),
        _GT(typeof(CameraClearFlags)),
        _GT(typeof(AudioClip)),
        _GT(typeof(AssetBundle)),
        _GT(typeof(ParticleSystem)),
        _GT(typeof(AsyncOperation)).SetBaseType(typeof(System.Object)),
        _GT(typeof(LightType)),
        _GT(typeof(Animator)),
        _GT(typeof(Input)),
        _GT(typeof(KeyCode)),
        _GT(typeof(SkinnedMeshRenderer)),
        _GT(typeof(Space)),
        _GT(typeof(MeshRenderer)),

        _GT(typeof(BoxCollider)),
        _GT(typeof(MeshCollider)),
        _GT(typeof(SphereCollider)),
        _GT(typeof(CharacterController)),
        _GT(typeof(CapsuleCollider)),

        _GT(typeof(Animation)),
        _GT(typeof(AnimationClip)).SetBaseType(typeof(UnityEngine.Object)),
        _GT(typeof(AnimationState)),
        _GT(typeof(AnimationBlendMode)),
        _GT(typeof(QueueMode)),
        _GT(typeof(PlayMode)),
        _GT(typeof(WrapMode)),

        _GT(typeof(QualitySettings)),
        _GT(typeof(RenderSettings)),
        _GT(typeof(BlendWeights)),
        _GT(typeof(RenderTexture)),
        _GT(typeof(Resources)),
        _GT(typeof(LuaProfiler)),

        //NGUI
        _GT(typeof(UIRoot)),
        _GT(typeof(UICamera)),
        _GT(typeof(UIViewport)),
        _GT(typeof(UIPanel)),
        _GT(typeof(UILabel)),
        _GT(typeof(UIAnchor)),
        _GT(typeof(UIAtlas)),
        _GT(typeof(UIFont)),
        _GT(typeof(UITexture)),
        _GT(typeof(UISprite)),
        _GT(typeof(UIGrid)),
        _GT(typeof(UITable)),
        _GT(typeof(UIInput)),
        _GT(typeof(UIEventListener)),
        _GT(typeof(UIScrollBar)),
        _GT(typeof(UICenterOnChild)),
        _GT(typeof(UIScrollView)),
        _GT(typeof(UIButton)),
        _GT(typeof(UITextList)),
        _GT(typeof(UIPlayTween)),
        _GT(typeof(UIDragScrollView)),
        _GT(typeof(UISpriteAnimation)),
        _GT(typeof(UIWrapContent)),
        _GT(typeof(TweenWidth)),
        _GT(typeof(TweenAlpha)),
        _GT(typeof(TweenColor)),
        _GT(typeof(TweenRotation)),
        _GT(typeof(TweenPosition)),
        _GT(typeof(TweenScale)),
        _GT(typeof(TweenHeight)),
        _GT(typeof(TypewriterEffect)),
        _GT(typeof(UIToggle)),
        _GT(typeof(Localization)),

        //业务逻辑
        //UI框架
        _GT(typeof(GameCore.UIMgr)),
        _GT(typeof(GameCore.UIFrame)),
        _GT(typeof(GameCore.UIEvent)),

        //调试
        _GT(typeof(LuaValueInfo)),
        _GT(typeof(LuaDebugTool)),

        //工具
        _GT(typeof(Utils)),
    };

    public static List<Type> dynamicList = new List<Type>()
    {
        typeof(MeshRenderer),

        typeof(BoxCollider),
        typeof(MeshCollider),
        typeof(SphereCollider),
        typeof(CharacterController),
        typeof(CapsuleCollider),

        typeof(Animation),
        typeof(AnimationClip),
        typeof(AnimationState),

        typeof(BlendWeights),
        typeof(RenderTexture),
        typeof(Rigidbody),
    };

    //重载函数，相同参数个数，相同位置out参数匹配出问题时, 需要强制匹配解决
    //使用方法参见例子14
    public static List<Type> outList = new List<Type>()
    {
        
    };
        
    //ngui优化，下面的类没有派生类，可以作为sealed class
    public static List<Type> sealedList = new List<Type>()
    {
    };

    public static BindType _GT(Type t)
    {
        return new BindType(t);
    }

    public static DelegateType _DT(Type t)
    {
        return new DelegateType(t);
    }    


    [MenuItem("Lua/Attach Profiler", false, 151)]
    static void AttachProfiler()
    {
        if (!Application.isPlaying)
        {
            EditorUtility.DisplayDialog("警告", "请在运行时执行此功能", "确定");
            return;
        }

        //LuaClient.Instance.AttachProfiler();
    }

    [MenuItem("Lua/Detach Profiler", false, 152)]
    static void DetachProfiler()
    {
        if (!Application.isPlaying)
        {            
            return;
        }

        //LuaClient.Instance.DetachProfiler();
    }
}
