using UnityEngine;
using System.Collections;

public class YellowWalkerAI : MonoBehaviour {
    public RaycastHit hit;

    public Quaternion targetRotation;
    public bool rotating = true;
    public float rotateSpeed = 120.0f;
    public float maxDistance = 10.0f;
    public float chargeDistanceMax = 10.0f;
    public float chargeDistance = 0.0f;
    public float rotation;
    public float chargeSpeed = 5.0f;
    public float storedWalkSpeed = 0.0f;

 

    void Update()
    {

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Physics.Raycast(transform.position, fwd, out hit, maxDistance);
        FPSAI controller = this.GetComponent<FPSAI>();

        if (Physics.Raycast(transform.position, fwd, maxDistance) && rotating == true)
        {
            print(hit.transform.tag);
            if (hit.transform.CompareTag("Player"))
            {
                rotating = false;
                controller.walkSpeed = chargeSpeed;
                storedWalkSpeed = controller.walkSpeed;
            }
        }

        if (rotating == true)
        {
            rotation = rotateSpeed * Time.deltaTime;
            this.transform.Rotate(0, rotation, 0);
            controller.walkSpeed = 0.0f;
            storedWalkSpeed = controller.walkSpeed;
        }
        if (rotating == false)
        {
            chargeDistance = chargeDistance + (storedWalkSpeed * Time.deltaTime);
            if (chargeDistance >= chargeDistanceMax)
            {
                rotating = true;
                chargeDistance = 0.0f;
                storedWalkSpeed = 0.0f;
                controller.walkSpeed = storedWalkSpeed;
            }
        }

    }
}