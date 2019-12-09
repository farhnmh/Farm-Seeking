<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class PrebuildSetupAttribute : Attribute
    {
        public PrebuildSetupAttribute(Type targetClass)
        {
            TargetClass = targetClass;
        }

        public PrebuildSetupAttribute(string targetClassName)
        {
            TargetClass = AttributeHelper.GetTargetClassFromName(targetClassName, typeof(IPrebuildSetup));
        }

        internal Type TargetClass { get; private set; }
    }
}
=======
using System;

namespace UnityEngine.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class PrebuildSetupAttribute : Attribute
    {
        public PrebuildSetupAttribute(Type targetClass)
        {
            TargetClass = targetClass;
        }

        public PrebuildSetupAttribute(string targetClassName)
        {
            TargetClass = AttributeHelper.GetTargetClassFromName(targetClassName, typeof(IPrebuildSetup));
        }

        internal Type TargetClass { get; private set; }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
