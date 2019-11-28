<<<<<<< HEAD
﻿using UnityEngine;
using UnityEngine.UI;


namespace TMPro
{
    /// <summary>
    /// A simple component that can be added to a newly created object where inheriting from MaskableGraphic is needed.
    /// </summary>
    public class TMP_SelectionCaret : MaskableGraphic
    {

        /// <summary>
        /// Override to Cull function of MaskableGraphic to prevent Culling.
        /// </summary>
        /// <param name="clipRect"></param>
        /// <param name="validRect"></param>
        public override void Cull(Rect clipRect, bool validRect)
        {
            //base.Cull(clipRect, validRect);
        }
    }
}
=======
﻿using UnityEngine;
using UnityEngine.UI;


namespace TMPro
{
    /// <summary>
    /// A simple component that can be added to a newly created object where inheriting from MaskableGraphic is needed.
    /// </summary>
    public class TMP_SelectionCaret : MaskableGraphic
    {

        /// <summary>
        /// Override to Cull function of MaskableGraphic to prevent Culling.
        /// </summary>
        /// <param name="clipRect"></param>
        /// <param name="validRect"></param>
        public override void Cull(Rect clipRect, bool validRect)
        {
            //base.Cull(clipRect, validRect);
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
