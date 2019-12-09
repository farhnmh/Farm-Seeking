<<<<<<< HEAD
using System.Collections;

namespace UnityEngine.TestTools
{
    public interface IEditModeTestYieldInstruction
    {
        bool ExpectDomainReload { get; }
        bool ExpectedPlaymodeState { get; }

        IEnumerator Perform();
    }
}
=======
using System.Collections;

namespace UnityEngine.TestTools
{
    public interface IEditModeTestYieldInstruction
    {
        bool ExpectDomainReload { get; }
        bool ExpectedPlaymodeState { get; }

        IEnumerator Perform();
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
