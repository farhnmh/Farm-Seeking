<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
=======
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
