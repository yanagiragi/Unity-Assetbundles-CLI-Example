using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public string bundlePath;

	void Start () {

		AssetBundle bundle = AssetBundle.LoadFromFile (bundlePath);

		GameObject target = bundle.LoadAssetAsync ("Pinocchio").asset as GameObject;

		GameObject i_target = Instantiate (target);

		/* Since Material may lost if not collect dependencies or other reasons, such as BUG, re-targeting material again */
		SkinnedMeshRenderer sk = i_target.GetComponentInChildren<SkinnedMeshRenderer> ();
		sk.material = Resources.Load ("Materials/No Name") as Material;

		/* Due to my model is small, adjust scale to 2000f */
		i_target.transform.localScale = new Vector3 (2000f, 2000f, 2000f);

	}

}
