<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;


namespace TMPro
{
    /// <summary>
    /// Custom text input validator where user can implement their own custom character validation.
    /// </summary>
    [System.Serializable]
    public abstract class TMP_InputValidator : ScriptableObject
    {
        public abstract char Validate(ref string text, ref int pos, char ch);
    }
}
=======
﻿using UnityEngine;
using System.Collections;


namespace TMPro
{
    /// <summary>
    /// Custom text input validator where user can implement their own custom character validation.
    /// </summary>
    [System.Serializable]
    public abstract class TMP_InputValidator : ScriptableObject
    {
        public abstract char Validate(ref string text, ref int pos, char ch);
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
