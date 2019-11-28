<<<<<<< HEAD
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal class PlaymodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new CoroutineTestWorkItem(method, filter);
        }
    }
}
=======
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal class PlaymodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new CoroutineTestWorkItem(method, filter);
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
