<<<<<<< HEAD
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class UnityTestTimeoutException : ResultStateException
    {
        public UnityTestTimeoutException(int timeout)
            : base(BuildMessage(timeout))
        {
        }

        private static string BuildMessage(int timeout)
        {
            return string.Format("UnityTest exceeded Timeout value of {0}ms", timeout);
        }

        public override ResultState ResultState
        {
            get { return ResultState.Failure; }
        }

        public override string StackTrace
        {
            get { return ""; }
        }
    }
}
=======
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class UnityTestTimeoutException : ResultStateException
    {
        public UnityTestTimeoutException(int timeout)
            : base(BuildMessage(timeout))
        {
        }

        private static string BuildMessage(int timeout)
        {
            return string.Format("UnityTest exceeded Timeout value of {0}ms", timeout);
        }

        public override ResultState ResultState
        {
            get { return ResultState.Failure; }
        }

        public override string StackTrace
        {
            get { return ""; }
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
