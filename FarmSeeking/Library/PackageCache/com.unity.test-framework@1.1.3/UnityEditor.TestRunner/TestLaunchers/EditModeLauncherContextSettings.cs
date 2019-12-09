<<<<<<< HEAD
using System;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModeLauncherContextSettings : IDisposable
    {
        private bool m_RunInBackground;

        public EditModeLauncherContextSettings()
        {
            SetupProjectParameters();
        }

        public void Dispose()
        {
            CleanupProjectParameters();
        }

        private void SetupProjectParameters()
        {
            m_RunInBackground = Application.runInBackground;
            Application.runInBackground = true;
        }

        private void CleanupProjectParameters()
        {
            Application.runInBackground = m_RunInBackground;
        }
    }
}
=======
using System;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModeLauncherContextSettings : IDisposable
    {
        private bool m_RunInBackground;

        public EditModeLauncherContextSettings()
        {
            SetupProjectParameters();
        }

        public void Dispose()
        {
            CleanupProjectParameters();
        }

        private void SetupProjectParameters()
        {
            m_RunInBackground = Application.runInBackground;
            Application.runInBackground = true;
        }

        private void CleanupProjectParameters()
        {
            Application.runInBackground = m_RunInBackground;
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7