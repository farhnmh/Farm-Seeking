<<<<<<< HEAD
﻿using System.Collections.Generic;


namespace TMPro
{
    internal static class TMP_ListPool<T>
    {      
        // Object pool to avoid allocations.
        private static readonly TMP_ObjectPool<List<T>> s_ListPool = new TMP_ObjectPool<List<T>>(null, l => l.Clear());

        public static List<T> Get()
        {
            return s_ListPool.Get();
        }

        public static void Release(List<T> toRelease)
        {
            s_ListPool.Release(toRelease);
        }
    }
=======
﻿using System.Collections.Generic;


namespace TMPro
{
    internal static class TMP_ListPool<T>
    {      
        // Object pool to avoid allocations.
        private static readonly TMP_ObjectPool<List<T>> s_ListPool = new TMP_ObjectPool<List<T>>(null, l => l.Clear());

        public static List<T> Get()
        {
            return s_ListPool.Get();
        }

        public static void Release(List<T> toRelease)
        {
            s_ListPool.Release(toRelease);
        }
    }
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
}