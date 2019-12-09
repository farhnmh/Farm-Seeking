<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class PostBuildCleanupAttribute : Attribute
    {
        public PostBuildCleanupAttribute(Type targetClass)
        {
            TargetClass = targetClass;
        }

        public PostBuildCleanupAttribute(string targetClassName)
        {
            TargetClass = AttributeHelper.GetTargetClassFromName(targetClassName, typeof(IPostBuildCleanup));
        }

        internal Type TargetClass { get; private set; }
    }
}
=======
using System;

namespace UnityEngine.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class PostBuildCleanupAttribute : Attribute
    {
        public PostBuildCleanupAttribute(Type targetClass)
        {
            TargetClass = targetClass;
        }

        public PostBuildCleanupAttribute(string targetClassName)
        {
            TargetClass = AttributeHelper.GetTargetClassFromName(targetClassName, typeof(IPostBuildCleanup));
        }

        internal Type TargetClass { get; private set; }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
