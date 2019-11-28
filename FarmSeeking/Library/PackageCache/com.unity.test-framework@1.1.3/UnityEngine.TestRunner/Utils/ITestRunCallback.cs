<<<<<<< HEAD
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner
{
    public interface ITestRunCallback
    {
        void RunStarted(ITest testsToRun);
        void RunFinished(ITestResult testResults);
        void TestStarted(ITest test);
        void TestFinished(ITestResult result);
    }
}
=======
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner
{
    public interface ITestRunCallback
    {
        void RunStarted(ITest testsToRun);
        void RunFinished(ITestResult testResults);
        void TestStarted(ITest test);
        void TestFinished(ITestResult result);
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
