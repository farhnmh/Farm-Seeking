<<<<<<< HEAD
using System;
using System.Collections;
using UnityEditor;

namespace UnityEngine.TestTools
{
    public class ExitPlayMode : IEditModeTestYieldInstruction
    {
        public bool ExpectDomainReload { get; }
        public bool ExpectedPlaymodeState { get; private set; }

        public ExitPlayMode()
        {
            ExpectDomainReload = false;
            ExpectedPlaymodeState = false;
        }

        public IEnumerator Perform()
        {
            if (!EditorApplication.isPlayingOrWillChangePlaymode)
            {
                throw new Exception("Editor is already in EditMode");
            }

            EditorApplication.isPlaying = false;
            while (EditorApplication.isPlaying)
            {
                yield return null;
            }
        }
    }
}
=======
using System;
using System.Collections;
using UnityEditor;

namespace UnityEngine.TestTools
{
    public class ExitPlayMode : IEditModeTestYieldInstruction
    {
        public bool ExpectDomainReload { get; }
        public bool ExpectedPlaymodeState { get; private set; }

        public ExitPlayMode()
        {
            ExpectDomainReload = false;
            ExpectedPlaymodeState = false;
        }

        public IEnumerator Perform()
        {
            if (!EditorApplication.isPlayingOrWillChangePlaymode)
            {
                throw new Exception("Editor is already in EditMode");
            }

            EditorApplication.isPlaying = false;
            while (EditorApplication.isPlaying)
            {
                yield return null;
            }
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
