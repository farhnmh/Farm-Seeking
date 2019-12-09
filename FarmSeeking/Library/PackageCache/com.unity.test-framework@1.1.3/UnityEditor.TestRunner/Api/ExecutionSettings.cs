<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    public class ExecutionSettings
    {
        public ExecutionSettings(params Filter[] filtersToExecute)
        {
            filters = filtersToExecute;
        }
        
        internal BuildTarget? targetPlatform;
        public ITestRunSettings overloadTestRunSettings;
        internal Filter filter;
        public Filter[] filters;
        public bool runSynchronously;
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    public class ExecutionSettings
    {
        public ExecutionSettings(params Filter[] filtersToExecute)
        {
            filters = filtersToExecute;
        }
        
        internal BuildTarget? targetPlatform;
        public ITestRunSettings overloadTestRunSettings;
        internal Filter filter;
        public Filter[] filters;
        public bool runSynchronously;
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
