<<<<<<< HEAD
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    class UtpDebugLogger : IUtpLogger
    {
        public void Log(Message msg)
        {
            var msgJson = JsonUtility.ToJson(msg);
            Debug.LogFormat(LogType.Log, LogOption.NoStacktrace, null, "\n##utp:{0}", msgJson);
        }
    }
}
=======
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    class UtpDebugLogger : IUtpLogger
    {
        public void Log(Message msg)
        {
            var msgJson = JsonUtility.ToJson(msg);
            Debug.LogFormat(LogType.Log, LogOption.NoStacktrace, null, "\n##utp:{0}", msgJson);
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
