<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Builders;

namespace UnityEngine.TestTools
{
    internal class UnityCombinatorialStrategy : CombinatorialStrategy, ICombiningStrategy
    {
        public new IEnumerable<ITestCaseData> GetTestCases(IEnumerable[] sources)
        {
            var testCases = base.GetTestCases(sources);
            foreach (var testCase in testCases)
            {
                testCase.GetType().GetProperty("ExpectedResult").SetValue(testCase, new object(), null);
            }
            return testCases;
        }
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Builders;

namespace UnityEngine.TestTools
{
    internal class UnityCombinatorialStrategy : CombinatorialStrategy, ICombiningStrategy
    {
        public new IEnumerable<ITestCaseData> GetTestCases(IEnumerable[] sources)
        {
            var testCases = base.GetTestCases(sources);
            foreach (var testCase in testCases)
            {
                testCase.GetType().GetProperty("ExpectedResult").SetValue(testCase, new object(), null);
            }
            return testCases;
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
