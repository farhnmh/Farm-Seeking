<<<<<<< HEAD
using System.Text.RegularExpressions;
using UnityEngine.TestTools.Logging;

namespace UnityEngine.TestTools
{
    public static class LogAssert
    {
        public static void Expect(LogType type, string message)
        {
            LogScope.Current.ExpectedLogs.Enqueue(new LogMatch() { LogType = type, Message = message });
        }

        public static void Expect(LogType type, Regex message)
        {
            LogScope.Current.ExpectedLogs.Enqueue(new LogMatch() { LogType = type, MessageRegex = message });
        }

        public static void NoUnexpectedReceived()
        {
            LogScope.Current.NoUnexpectedReceived();
        }

        public static bool ignoreFailingMessages
        {
            get
            {
                return LogScope.Current.IgnoreFailingMessages;
            }
            set
            {
                if (value != LogScope.Current.IgnoreFailingMessages)
                {
                    Debug.LogFormat(LogType.Log, LogOption.NoStacktrace, null, "\nIgnoreFailingMessages:" + (value? "true":"false"));
                }
                LogScope.Current.IgnoreFailingMessages = value;
            }
        }
    }
}
=======
using System.Text.RegularExpressions;
using UnityEngine.TestTools.Logging;

namespace UnityEngine.TestTools
{
    public static class LogAssert
    {
        public static void Expect(LogType type, string message)
        {
            LogScope.Current.ExpectedLogs.Enqueue(new LogMatch() { LogType = type, Message = message });
        }

        public static void Expect(LogType type, Regex message)
        {
            LogScope.Current.ExpectedLogs.Enqueue(new LogMatch() { LogType = type, MessageRegex = message });
        }

        public static void NoUnexpectedReceived()
        {
            LogScope.Current.NoUnexpectedReceived();
        }

        public static bool ignoreFailingMessages
        {
            get
            {
                return LogScope.Current.IgnoreFailingMessages;
            }
            set
            {
                if (value != LogScope.Current.IgnoreFailingMessages)
                {
                    Debug.LogFormat(LogType.Log, LogOption.NoStacktrace, null, "\nIgnoreFailingMessages:" + (value? "true":"false"));
                }
                LogScope.Current.IgnoreFailingMessages = value;
            }
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7