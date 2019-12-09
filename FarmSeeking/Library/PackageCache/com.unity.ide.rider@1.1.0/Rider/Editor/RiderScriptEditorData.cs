<<<<<<< HEAD
using UnityEditor;
using UnityEngine;

namespace Packages.Rider.Editor
{
  public class RiderScriptEditorData:ScriptableSingleton<RiderScriptEditorData>
  {
    [SerializeField] internal bool HasChanges = true; // sln/csproj files were changed
  }
=======
using UnityEditor;
using UnityEngine;

namespace Packages.Rider.Editor
{
  public class RiderScriptEditorData:ScriptableSingleton<RiderScriptEditorData>
  {
    [SerializeField] internal bool HasChanges = true; // sln/csproj files were changed
  }
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
}