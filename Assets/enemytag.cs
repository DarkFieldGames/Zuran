using UnityEngine;
using System.Collections;

public class enemytag : MonoBehaviour {

    // Use this for initialization
    private GameObject red_walker;
    private GameObject blue_walker;
    private GameObject green_walker;
    private GameObject yellow_walker;

    void Start () {

        RedWalkerAI red_walk_ai = GetComponent<RedWalkerAI>();
        BlueWalkerAI blue_walk_ai = GetComponent<BlueWalkerAI>();
        GreenWalkerAI green_walk_ai = GetComponent<GreenWalkerAI>();
        YellowWalkerAI yellow_walk_ai = GetComponent<YellowWalkerAI>();
        red_walker = gameObject.transform.Find("RedWalker").gameObject;
        blue_walker = gameObject.transform.Find("BlueWalker").gameObject;
        green_walker = gameObject.transform.Find("GreenWalker").gameObject;
        yellow_walker = gameObject.transform.Find("YellowWalker").gameObject;

        if (gameObject.tag == "RedEnemy")
        {
            blue_walk_ai.enabled = false;
            red_walk_ai.enabled = true;
            green_walk_ai.enabled = false;
            yellow_walk_ai.enabled = false;
            red_walker.SetActive(true);
            blue_walker.SetActive(false);
            green_walker.SetActive(false);
            yellow_walker.SetActive(false);
        }

        if (gameObject.tag == "BlueEnemy")
        {
            blue_walk_ai.enabled = true;
            red_walk_ai.enabled = false;
            green_walk_ai.enabled = false;
            yellow_walk_ai.enabled = false;
            red_walker.SetActive(false);
            blue_walker.SetActive(true);
            green_walker.SetActive(false);
            yellow_walker.SetActive(false);
        }

        if (gameObject.tag == "GreenEnemy")
        {
            blue_walk_ai.enabled = false;
            red_walk_ai.enabled = false;
            green_walk_ai.enabled = true;
            yellow_walk_ai.enabled = false;
            red_walker.SetActive(false);
            blue_walker.SetActive(false);
            green_walker.SetActive(true);
            yellow_walker.SetActive(false);
        }
        if (gameObject.tag == "YellowEnemy")
        {
            blue_walk_ai.enabled = false;
            red_walk_ai.enabled = false;
            green_walk_ai.enabled = false;
            yellow_walk_ai.enabled = true;
            red_walker.SetActive(false);
            blue_walker.SetActive(false);
            green_walker.SetActive(false);
            yellow_walker.SetActive(true);
        }

    }

    void FixedUpdate()
    {

        RedWalkerAI red_walk_ai = GetComponent<RedWalkerAI>();
        BlueWalkerAI blue_walk_ai = GetComponent<BlueWalkerAI>();
        GreenWalkerAI green_walk_ai = GetComponent<GreenWalkerAI>();
        YellowWalkerAI yellow_walk_ai = GetComponent<YellowWalkerAI>();
        red_walker = gameObject.transform.Find("RedWalker").gameObject;
        blue_walker = gameObject.transform.Find("BlueWalker").gameObject;
        green_walker = gameObject.transform.Find("GreenWalker").gameObject;
        yellow_walker = gameObject.transform.Find("YellowWalker").gameObject;

        if (gameObject.tag == "RedEnemy")
        {
            blue_walk_ai.enabled = false;
            red_walk_ai.enabled = true;
            green_walk_ai.enabled = false;
            yellow_walk_ai.enabled = false;
            red_walker.SetActive(true);
            blue_walker.SetActive(false);
            green_walker.SetActive(false);
            yellow_walker.SetActive(false);
        }

        if (gameObject.tag == "BlueEnemy")
        {
            blue_walk_ai.enabled = true;
            red_walk_ai.enabled = false;
            green_walk_ai.enabled = false;
            yellow_walk_ai.enabled = false;
            red_walker.SetActive(false);
            blue_walker.SetActive(true);
            green_walker.SetActive(false);
            yellow_walker.SetActive(false);
        }

        if (gameObject.tag == "GreenEnemy")
        {
            blue_walk_ai.enabled = false;
            red_walk_ai.enabled = false;
            green_walk_ai.enabled = true;
            yellow_walk_ai.enabled = false;
            red_walker.SetActive(false);
            blue_walker.SetActive(false);
            green_walker.SetActive(true);
            yellow_walker.SetActive(false);
        }
        if (gameObject.tag == "YellowEnemy")
        {
            blue_walk_ai.enabled = false;
            red_walk_ai.enabled = false;
            green_walk_ai.enabled = false;
            yellow_walk_ai.enabled = true;
            red_walker.SetActive(false);
            blue_walker.SetActive(false);
            green_walker.SetActive(false);
            yellow_walker.SetActive(true);
        }


    }
}
