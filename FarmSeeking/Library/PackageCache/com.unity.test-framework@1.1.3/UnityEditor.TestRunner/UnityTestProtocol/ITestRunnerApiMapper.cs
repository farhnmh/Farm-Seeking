<<<<<<< HEAD
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    interface ITestRunnerApiMapper
    {
        string GetRunStateFromResultNunitXml(ITestResultAdaptor result);
        TestState GetTestStateFromResult(ITestResultAdaptor result);
        List<string> FlattenTestNames(ITestAdaptor testsToRun);
        TestPlanMessage MapTestToTestPlanMessage(ITestAdaptor testsToRun);
        TestStartedMessage MapTestToTestStartedMessage(ITestAdaptor test);
        TestFinishedMessage TestResultToTestFinishedMessage(ITestResultAdaptor result);
    }
}
=======
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    interface ITestRunnerApiMapper
    {
        string GetRunStateFromResultNunitXml(ITestResultAdaptor result);
        TestState GetTestStateFromResult(ITestResultAdaptor result);
        List<string> FlattenTestNames(ITestAdaptor testsToRun);
        TestPlanMessage MapTestToTestPlanMessage(ITestAdaptor testsToRun);
        TestStartedMessage MapTestToTestStartedMessage(ITestAdaptor test);
        TestFinishedMessage TestResultToTestFinishedMessage(ITestResultAdaptor result);
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
