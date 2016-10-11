using UnityEngine;
using System.Collections;
using UnityEditor;

public class CreateAssetBundles : MonoBehaviour {

	[MenuItem("AssetBunldes/Create AssetBunldes With Specific targets")]
	static void CreateAssetBundlesMain ()
	{
		AssetBundleBuild[] buildMap = new AssetBundleBuild[1];

		buildMap[0].assetBundleName = "testbundle";

		string[] myAssets = new string[1];
		myAssets[0] = "Assets/Pinocchio.fbx";
		buildMap[0].assetNames = myAssets;

		BuildPipeline.BuildAssetBundles( "Assets/StreamingAssets", buildMap, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows );
	}
}
