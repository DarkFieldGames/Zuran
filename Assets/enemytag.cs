using UnityEngine;
using System.Collections;

public class enemytag : MonoBehaviour {

    // Use this for initialization
    private GameObject red_walker;
    private GameObject blue_walker;

	void Start () {

        CircleWalker circle_walker = GetComponent<CircleWalker>();
        LeftRightWalker left_right_walker = GetComponent<LeftRightWalker>();
        red_walker = this.transform.Find("RedWalker").gameObject;
        blue_walker = gameObject.transform.Find("BlueWalker").gameObject;

        if (gameObject.tag == "RedEnemy")
        {
            circle_walker.enabled = false;
            left_right_walker.enabled = true;
            red_walker.SetActive(true);
            blue_walker.SetActive(false);
        }

        if (gameObject.tag == "BlueEnemy")
        {
            circle_walker.enabled = true;
            left_right_walker.enabled = false;
            red_walker.SetActive(false);
            blue_walker.SetActive(true);
        }

        if (gameObject.tag == "GreenEnemy")
        {
            circle_walker.enabled = false;
            left_right_walker.enabled = true;
        }

    }

    void FixedUpdate()
    {

        CircleWalker circle_walker = GetComponent<CircleWalker>();
        LeftRightWalker left_right_walker = GetComponent<LeftRightWalker>();
        red_walker = this.transform.Find("RedWalker").gameObject;
        blue_walker = gameObject.transform.Find("BlueWalker").gameObject;

        if (gameObject.tag == "RedEnemy")
        {
            circle_walker.enabled = false;
            left_right_walker.enabled = true;
            red_walker.SetActive(true);
            blue_walker.SetActive(false);
        }

        if (gameObject.tag == "BlueEnemy")
        {
            circle_walker.enabled = true;
            left_right_walker.enabled = false;
            red_walker.SetActive(false);
            blue_walker.SetActive(true);
        }

        if (gameObject.tag == "GreenEnemy")
        {
            circle_walker.enabled = false;
            left_right_walker.enabled = true;
        }

    }
}
