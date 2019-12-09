<<<<<<< HEAD
using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector2ComparerWithEqualsOperator : IEqualityComparer<Vector2>
    {
        private static readonly Vector2ComparerWithEqualsOperator m_Instance = new Vector2ComparerWithEqualsOperator();
        public static Vector2ComparerWithEqualsOperator Instance { get { return m_Instance; } }

        private Vector2ComparerWithEqualsOperator() {}

        public bool Equals(Vector2 expected, Vector2 actual)
        {
            return expected == actual;
        }

        public int GetHashCode(Vector2 vec2)
        {
            return 0;
        }
    }
}
=======
using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector2ComparerWithEqualsOperator : IEqualityComparer<Vector2>
    {
        private static readonly Vector2ComparerWithEqualsOperator m_Instance = new Vector2ComparerWithEqualsOperator();
        public static Vector2ComparerWithEqualsOperator Instance { get { return m_Instance; } }

        private Vector2ComparerWithEqualsOperator() {}

        public bool Equals(Vector2 expected, Vector2 actual)
        {
            return expected == actual;
        }

        public int GetHashCode(Vector2 vec2)
        {
            return 0;
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7