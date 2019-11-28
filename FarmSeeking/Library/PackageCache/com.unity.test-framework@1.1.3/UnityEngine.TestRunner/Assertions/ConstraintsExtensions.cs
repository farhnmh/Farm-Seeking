<<<<<<< HEAD
using NUnit.Framework.Constraints;

namespace UnityEngine.TestTools.Constraints
{
    public static class ConstraintExtensions
    {
        public static AllocatingGCMemoryConstraint AllocatingGCMemory(this ConstraintExpression chain)
        {
            var constraint = new AllocatingGCMemoryConstraint();
            chain.Append(constraint);
            return constraint;
        }
    }
}
=======
using NUnit.Framework.Constraints;

namespace UnityEngine.TestTools.Constraints
{
    public static class ConstraintExtensions
    {
        public static AllocatingGCMemoryConstraint AllocatingGCMemory(this ConstraintExpression chain)
        {
            var constraint = new AllocatingGCMemoryConstraint();
            chain.Append(constraint);
            return constraint;
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
