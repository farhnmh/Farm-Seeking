<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools
{
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        All = 0xFF,
        EditMode = 1 << 1,
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
=======
using System;

namespace UnityEngine.TestTools
{
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        All = 0xFF,
        EditMode = 1 << 1,
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
