using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
    }


    void Update()
        {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
