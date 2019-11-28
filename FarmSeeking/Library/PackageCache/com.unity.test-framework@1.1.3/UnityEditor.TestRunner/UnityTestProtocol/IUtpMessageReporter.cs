<<<<<<< HEAD
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal interface IUtpMessageReporter
    {
        void ReportAssemblyCompilationErrors(string assembly, IEnumerable<CompilerMessage> errorCompilerMessages);
        void ReportTestFinished(ITestResultAdaptor result);
        void ReportTestRunStarted(ITestAdaptor testsToRun);
        void ReportTestStarted(ITestAdaptor test);
    }
}
=======
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal interface IUtpMessageReporter
    {
        void ReportAssemblyCompilationErrors(string assembly, IEnumerable<CompilerMessage> errorCompilerMessages);
        void ReportTestFinished(ITestResultAdaptor result);
        void ReportTestRunStarted(ITestAdaptor testsToRun);
        void ReportTestStarted(ITestAdaptor test);
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
