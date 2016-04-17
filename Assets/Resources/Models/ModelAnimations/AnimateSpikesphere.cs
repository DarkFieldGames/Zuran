using UnityEngine;
using System.Collections;

public class AnilateSpikesphere : MonoBehaviour {

	public float speed = 3.5f;
	public bool animate = true;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (!animate)
			return;

		var transforms = gameObject.GetComponentsInChildren (typeof(Transform));
		foreach (Transform t in transforms) {
			if (t.name == "Cube10_se4" || t.name == "sphere1_s5") {
				Vector3 angle = t.localEulerAngles;
				angle.x = -10.0f + (25.0f * Mathf.Sin (Time.fixedTime * speed));
				t.localEulerAngles = angle;
			} else if (t.name == "Cube10_se6" || t.name == "sphere1_s7") {
				Vector3 angle = t.localEulerAngles;
				angle.y = +5.0f - (10.0f * Mathf.Sin (Time.fixedTime * speed));
				angle.x = +5.0f + 10.0f - (10.0f * Mathf.Sin (Time.fixedTime * speed));
				t.localEulerAngles = angle;
			} else if (t.name == "Cube10_cop" || t.name == "sphere1_co") {
				Vector3 angle = t.localEulerAngles;
				angle.y = -5.0f + (10.0f * Mathf.Sin (Time.fixedTime * speed));
				angle.x = +5.0f - (10.0f * Mathf.Sin (Time.fixedTime * speed));
				t.localEulerAngles = angle;
			}
		}
	}
}
