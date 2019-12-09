<<<<<<< HEAD
using System;

namespace UnityEngine.TestRunner
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class TestRunCallbackAttribute : Attribute
    {
        private Type m_Type;
        public TestRunCallbackAttribute(Type type)
        {
            var interfaceType = typeof(ITestRunCallback);
            if (!interfaceType.IsAssignableFrom(type))
            {
                throw new ArgumentException(string.Format("Type provided to {0} does not implement {1}", this.GetType().Name, interfaceType.Name));
            }
            m_Type = type;
        }

        internal ITestRunCallback ConstructCallback()
        {
            return Activator.CreateInstance(m_Type) as ITestRunCallback;
        }
    }
}
=======
using System;

namespace UnityEngine.TestRunner
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class TestRunCallbackAttribute : Attribute
    {
        private Type m_Type;
        public TestRunCallbackAttribute(Type type)
        {
            var interfaceType = typeof(ITestRunCallback);
            if (!interfaceType.IsAssignableFrom(type))
            {
                throw new ArgumentException(string.Format("Type provided to {0} does not implement {1}", this.GetType().Name, interfaceType.Name));
            }
            m_Type = type;
        }

        internal ITestRunCallback ConstructCallback()
        {
            return Activator.CreateInstance(m_Type) as ITestRunCallback;
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
