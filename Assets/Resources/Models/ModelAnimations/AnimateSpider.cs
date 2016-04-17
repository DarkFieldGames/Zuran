using UnityEngine;
using System.Collections;

public class AnimateSpider : MonoBehaviour {

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
			if (t.name == "Cube1_cop1") {
				Vector3 pos = t.localPosition;
				pos.z = 0.5f * Mathf.Sin(Time.fixedTime * speed);
				pos.y = 0.5f * Mathf.Cos(Time.fixedTime * speed);
				t.localPosition = pos;

				Vector3 tilt = t.localEulerAngles;
				tilt.x = 10.0f * -Mathf.Sin(Time.fixedTime * speed);
				if (tilt.x > 0)
					tilt.x = 0;
				t.localEulerAngles = tilt;

			} else if (t.name == "Cube1_cop3") {
				Vector3 pos = t.localPosition;
				pos.z = 0.5f * Mathf.Sin(Time.fixedTime * speed + (2*Mathf.PI/3));
				pos.y = 0.5f * Mathf.Cos(Time.fixedTime * speed + (2*Mathf.PI/3));
				t.localPosition = pos;

				Vector3 tilt = t.localEulerAngles;
				tilt.x = 5.0f * -Mathf.Sin(Time.fixedTime * speed + (2*Mathf.PI/3));
				//if (tilt.x < 0)
				//	tilt.x = 0;
				t.localEulerAngles = tilt;

			} else if (t.name == "Cube1_sep1") {
				Vector3 pos = t.localPosition;
				pos.z = 0.5f * Mathf.Sin(Time.fixedTime * speed + (4*Mathf.PI/3));
				pos.y = 0.5f * Mathf.Cos(Time.fixedTime * speed + (4*Mathf.PI/3));
				t.localPosition = pos;

				Vector3 tilt = t.localEulerAngles;
				tilt.x = 10.0f * -Mathf.Sin(Time.fixedTime * speed + (4*Mathf.PI/3));
				if (tilt.x < 0)
					tilt.x = 0;
				t.localEulerAngles = tilt;
			}
		}
	}
}
