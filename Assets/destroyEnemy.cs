using UnityEngine;
using System.Collections;

public class destroyEnemy : MonoBehaviour {
    public RaycastHit hit;
    public float maxDistance = 6.2f;
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Physics.Raycast(transform.position, fwd, out hit, maxDistance);
        if (Physics.Raycast(transform.position, fwd, maxDistance))
        {
            if ((hit.transform.root.gameObject.transform.tag != gameObject.tag) && (hit.transform.root.gameObject.transform.tag != "Wall") && (hit.transform.root.gameObject.transform.tag != "Player"))
            {
                print("destroy");
                print(hit.transform.tag);
                print(gameObject.tag);
                //Destroy(hit.gameObject);
                Destroy(this.transform.root.gameObject);
                Destroy(hit.transform.root.gameObject);
            }
        }
    }
}
