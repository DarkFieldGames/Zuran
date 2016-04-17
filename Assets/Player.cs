using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void OnTriggerEnter(Collider c)
    {
        print("collide");
        // Does the other collider have the tag "Player"? 
        if (c.transform.root.gameObject.tag == "RedEnemy")
        {
            // Yes it does. Destroy the entire gameObject.
            print("you lose");
            Application.Quit();
        }

        if (c.transform.root.gameObject.tag == "BlueEnemy")
        {
            // Yes it does. Destroy the entire gameObject. 
            print("you lose");
            Application.Quit();
        }

        if (c.transform.root.gameObject.tag == "GreenEnemy")
        {
            // Yes it does. Destroy the entire gameObject. 
            print("you lose");
            Application.Quit();
        }

        if (c.transform.root.gameObject.tag == "YellowEnemy")
        {
            // Yes it does. Destroy the entire gameObject.
            print("you lose");
            Application.Quit();
        }

    }
}
