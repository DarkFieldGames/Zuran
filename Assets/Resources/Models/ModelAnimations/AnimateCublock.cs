using UnityEngine;
using System.Collections;

public class AnimateCublock : MonoBehaviour {

	public float speed = 2.0f;
	public bool animate = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!animate)
			return;

		var transforms = gameObject.GetComponentsInChildren(typeof(Transform));
		foreach (Transform t in transforms)
		{
			if (t.name == "Cube1") {
				Vector3 ypos = t.localPosition;
				ypos.y = 0.05f * (0.5f + Mathf.Sin (Time.fixedTime*speed));
				t.localPosition = ypos;
			} else if (t.name == "Cube1_ext4" || t.name == "Cure1_ext6") {
				Vector3 ypos = t.localPosition;
				ypos.y = 0.05f * (0.5f - Mathf.Sin (Time.fixedTime*speed));
				t.localPosition = ypos;
			}
		}
	}
}
