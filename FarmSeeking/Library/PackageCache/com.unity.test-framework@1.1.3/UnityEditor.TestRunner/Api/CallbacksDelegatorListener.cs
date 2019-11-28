<<<<<<< HEAD
using UnityEngine;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal class CallbacksDelegatorListener : ScriptableObject, ITestRunnerListener
    {
        public void RunStarted(NUnit.Framework.Interfaces.ITest testsToRun)
        {
            CallbacksDelegator.instance.RunStarted(testsToRun);
        }

        public void RunFinished(NUnit.Framework.Interfaces.ITestResult testResults)
        {
            CallbacksDelegator.instance.RunFinished(testResults);
        }

        public void TestStarted(NUnit.Framework.Interfaces.ITest test)
        {
            CallbacksDelegator.instance.TestStarted(test);
        }

        public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
        {
            CallbacksDelegator.instance.TestFinished(result);
        }
    }
}
=======
using UnityEngine;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal class CallbacksDelegatorListener : ScriptableObject, ITestRunnerListener
    {
        public void RunStarted(NUnit.Framework.Interfaces.ITest testsToRun)
        {
            CallbacksDelegator.instance.RunStarted(testsToRun);
        }

        public void RunFinished(NUnit.Framework.Interfaces.ITestResult testResults)
        {
            CallbacksDelegator.instance.RunFinished(testResults);
        }

        public void TestStarted(NUnit.Framework.Interfaces.ITest test)
        {
            CallbacksDelegator.instance.TestStarted(test);
        }

        public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
        {
            CallbacksDelegator.instance.TestFinished(result);
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
