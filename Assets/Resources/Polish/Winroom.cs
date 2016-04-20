using UnityEngine;
using System.Collections;

public class Winroom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c)
	{
		// Does the other collider have the tag "Player"? 
		if (c.gameObject.tag == "Player")
		{
			// Yes it does. Destroy the entire gameObject.
			print("you win");
			if (!GameObject.Find("UWin(Clone)"))
			{
				Instantiate(Resources.Load("Polish/UWin"));
			}
			/*
			var player = GameObject.Find("Player");
			if (player) {
				player.GetComponent<FPSCharacterController>().enabled = false;
				player.GetComponent<FPSMouseLook>().enabled = false;
			}
			*/
		}

	}

}
