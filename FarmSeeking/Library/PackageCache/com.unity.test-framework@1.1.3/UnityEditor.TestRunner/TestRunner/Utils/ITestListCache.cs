<<<<<<< HEAD
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    interface ITestListCache
    {
        void CacheTest(TestPlatform platform, ITest test);
        IEnumerator<ITestAdaptor> GetTestFromCacheAsync(TestPlatform platform);
    }
}
=======
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    interface ITestListCache
    {
        void CacheTest(TestPlatform platform, ITest test);
        IEnumerator<ITestAdaptor> GetTestFromCacheAsync(TestPlatform platform);
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
