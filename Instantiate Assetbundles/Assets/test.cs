using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public string bundlePath;

	void Start () {

		AssetBundle bundle = AssetBundle.LoadFromFile (bundlePath);

		// GameObject target = bundle.LoadAssetAsync ("Pinocchio").asset as GameObject;
		GameObject target = bundle.LoadAsset ("Pinocchio").asset as GameObject;

		/* My Recommandation is to not using Async, it appears to possible trigger error "m_Instance != 0" */
		/* Reference : http://stackoverflow.com/questions/39628951/error-m-instanceid-0-when-downloading-texture-from-the-server */
		
		GameObject i_target = Instantiate (target);

		/* Since Material may lost if not collect dependencies or other reasons, such as BUG, re-targeting material again */
		SkinnedMeshRenderer sk = i_target.GetComponentInChildren<SkinnedMeshRenderer> ();
		sk.material = Resources.Load ("Materials/No Name") as Material;

		/* Due to my model is small, adjust scale to 2000f */
		i_target.transform.localScale = new Vector3 (2000f, 2000f, 2000f);

	}

}
