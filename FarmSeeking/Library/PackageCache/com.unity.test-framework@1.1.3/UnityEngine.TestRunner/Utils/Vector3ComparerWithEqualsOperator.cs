<<<<<<< HEAD
using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector3ComparerWithEqualsOperator : IEqualityComparer<Vector3>
    {
        private static readonly Vector3ComparerWithEqualsOperator m_Instance = new Vector3ComparerWithEqualsOperator();
        public static Vector3ComparerWithEqualsOperator Instance { get { return m_Instance; } }

        private Vector3ComparerWithEqualsOperator() {}

        public bool Equals(Vector3 expected, Vector3 actual)
        {
            return expected == actual;
        }

        public int GetHashCode(Vector3 vec3)
        {
            return 0;
        }
    }
}
=======
using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector3ComparerWithEqualsOperator : IEqualityComparer<Vector3>
    {
        private static readonly Vector3ComparerWithEqualsOperator m_Instance = new Vector3ComparerWithEqualsOperator();
        public static Vector3ComparerWithEqualsOperator Instance { get { return m_Instance; } }

        private Vector3ComparerWithEqualsOperator() {}

        public bool Equals(Vector3 expected, Vector3 actual)
        {
            return expected == actual;
        }

        public int GetHashCode(Vector3 vec3)
        {
            return 0;
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
