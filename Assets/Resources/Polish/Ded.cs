using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ded : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Space)) {
			SceneManager.LoadScene("game");
		}
	}
}
