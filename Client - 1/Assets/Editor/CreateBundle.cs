#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateBundle : MonoBehaviour
{
    [MenuItem("Assets/Create Asset Bundles")]
    static void Build()
    {
        BuildPipeline.BuildAssetBundles("AssetBundles/StandaloneWindows", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}

#endif