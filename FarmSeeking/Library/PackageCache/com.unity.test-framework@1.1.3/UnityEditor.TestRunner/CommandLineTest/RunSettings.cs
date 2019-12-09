<<<<<<< HEAD
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class RunSettings : ITestRunSettings
    {
        private ITestSettings m_TestSettings;
        public RunSettings(ITestSettings testSettings)
        {
            this.m_TestSettings = testSettings;
        }

        public void Apply()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.SetupProjectParameters();
            }
        }

        public void Dispose()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.Dispose();
            }
        }
    }
}
=======
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class RunSettings : ITestRunSettings
    {
        private ITestSettings m_TestSettings;
        public RunSettings(ITestSettings testSettings)
        {
            this.m_TestSettings = testSettings;
        }

        public void Apply()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.SetupProjectParameters();
            }
        }

        public void Dispose()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.Dispose();
            }
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
