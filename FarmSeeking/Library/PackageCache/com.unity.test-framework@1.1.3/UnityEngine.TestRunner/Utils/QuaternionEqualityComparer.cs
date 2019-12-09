<<<<<<< HEAD
using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class QuaternionEqualityComparer : IEqualityComparer<Quaternion>
    {
        private const float k_DefaultError = 0.00001f;
        private readonly float AllowedError;

        private static readonly QuaternionEqualityComparer m_Instance = new QuaternionEqualityComparer();
        public static QuaternionEqualityComparer Instance { get { return m_Instance; } }


        private QuaternionEqualityComparer() : this(k_DefaultError) {}

        public QuaternionEqualityComparer(float allowedError)
        {
            AllowedError = allowedError;
        }

        public bool Equals(Quaternion expected, Quaternion actual)
        {
            return Mathf.Abs(Quaternion.Dot(expected, actual)) > (1.0f - AllowedError);
        }

        public int GetHashCode(Quaternion quaternion)
        {
            return 0;
        }
    }
}
=======
using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class QuaternionEqualityComparer : IEqualityComparer<Quaternion>
    {
        private const float k_DefaultError = 0.00001f;
        private readonly float AllowedError;

        private static readonly QuaternionEqualityComparer m_Instance = new QuaternionEqualityComparer();
        public static QuaternionEqualityComparer Instance { get { return m_Instance; } }


        private QuaternionEqualityComparer() : this(k_DefaultError) {}

        public QuaternionEqualityComparer(float allowedError)
        {
            AllowedError = allowedError;
        }

        public bool Equals(Quaternion expected, Quaternion actual)
        {
            return Mathf.Abs(Quaternion.Dot(expected, actual)) > (1.0f - AllowedError);
        }

        public int GetHashCode(Quaternion quaternion)
        {
            return 0;
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7