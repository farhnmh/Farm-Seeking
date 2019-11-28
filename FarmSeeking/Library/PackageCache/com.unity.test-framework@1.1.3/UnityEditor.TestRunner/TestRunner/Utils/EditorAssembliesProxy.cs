<<<<<<< HEAD
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
=======
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
