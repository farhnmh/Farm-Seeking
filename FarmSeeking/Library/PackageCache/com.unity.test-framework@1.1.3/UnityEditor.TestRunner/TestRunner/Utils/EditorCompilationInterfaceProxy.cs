<<<<<<< HEAD
using UnityEditor.Scripting.ScriptCompilation;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorCompilationInterfaceProxy : IEditorCompilationInterfaceProxy
    {
        public ScriptAssembly[] GetAllEditorScriptAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllEditorScriptAssemblies(EditorCompilationInterface.GetAdditionalEditorScriptCompilationOptions());
        }

        public PrecompiledAssembly[] GetAllPrecompiledAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllPrecompiledAssemblies();
        }
    }
}
=======
using UnityEditor.Scripting.ScriptCompilation;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorCompilationInterfaceProxy : IEditorCompilationInterfaceProxy
    {
        public ScriptAssembly[] GetAllEditorScriptAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllEditorScriptAssemblies(EditorCompilationInterface.GetAdditionalEditorScriptCompilationOptions());
        }

        public PrecompiledAssembly[] GetAllPrecompiledAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllPrecompiledAssemblies();
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
