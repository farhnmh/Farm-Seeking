<<<<<<< HEAD
namespace UnityEngine.TestTools.Logging
{
    internal class LogEvent
    {
        public string Message { get; set; }

        public string StackTrace { get; set; }

        public LogType LogType { get; set; }

        public bool IsHandled { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1}", LogType, Message);
        }
    }
}
=======
namespace UnityEngine.TestTools.Logging
{
    internal class LogEvent
    {
        public string Message { get; set; }

        public string StackTrace { get; set; }

        public LogType LogType { get; set; }

        public bool IsHandled { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1}", LogType, Message);
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
