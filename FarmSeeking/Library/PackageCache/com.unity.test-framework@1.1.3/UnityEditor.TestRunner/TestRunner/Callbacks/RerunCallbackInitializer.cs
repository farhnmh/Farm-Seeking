<<<<<<< HEAD
using UnityEngine;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    [InitializeOnLoad]
    static class RerunCallbackInitializer
    {
        static RerunCallbackInitializer()
        {
            var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();

            var rerunCallback = ScriptableObject.CreateInstance<RerunCallback>();
            testRunnerApi.RegisterCallbacks<RerunCallback>(rerunCallback);
        }
    }
}
=======
using UnityEngine;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    [InitializeOnLoad]
    static class RerunCallbackInitializer
    {
        static RerunCallbackInitializer()
        {
            var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();

            var rerunCallback = ScriptableObject.CreateInstance<RerunCallback>();
            testRunnerApi.RegisterCallbacks<RerunCallback>(rerunCallback);
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
