using UnityEngine;
using System.Collections;

public class AnimateSpheres : MonoBehaviour {

	public float speed = 30.0f;
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
			if (t.name == "sphere5_c6")
				t.Rotate(Vector3.up, speed * Time.deltaTime);
			else if (t.name == "Cube1")
				t.Rotate(Vector3.up, -speed * Time.deltaTime);
		}
		//Debug.Log (a);


	}
}
