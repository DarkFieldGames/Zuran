using UnityEngine;
using System.Collections;

public class RemoveTag : MonoBehaviour {

    void OnTriggerEnter(Collider c)
    {
        // Does the other collider have the tag "Player"? 
        if (c.gameObject.tag == "Player")
        {
            // Yes it does. Destroy the entire gameObject.
            RayCast cast = c.gameObject.GetComponentInChildren<RayCast>();
            cast.CurrentTag = string.Empty;
        }

    }
}
