using UnityEngine;
using System.Collections;

public class AnimateBoss : MonoBehaviour {

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
			if (t.name == "Cylinder2c" || t.name == "Cylinder2e") {
				Vector3 ypos = t.localPosition;
				ypos.y = 0.1f * Mathf.Sin (Time.fixedTime*speed);
				t.localPosition = ypos;
			}
			else if (t.name == "Cylinder2") {
				Vector3 ypos = t.localPosition;
				ypos.y = -0.03f * Mathf.Sin (Time.fixedTime*speed);
				t.localPosition = ypos;
			}
		}
	}
}
