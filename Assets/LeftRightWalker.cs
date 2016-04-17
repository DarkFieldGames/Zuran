﻿using UnityEngine;
using System.Collections;

public class LeftRightWalker : MonoBehaviour {
    public RaycastHit hit;
    public Quaternion targetRotation;
    public bool rotating = false;
    public float rotateMax = 180.0f;
    public float maxDistance = 3.0f;
    public float rotateSpeed = 180.0f;
    public float rotateCurrent = 0.0f;
    public float rotation;
    public float storedWalkSpeed = 0.0f;

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Physics.Raycast(transform.position, fwd, out hit, 5);
        FPSAI controller = this.GetComponent<FPSAI>();

        if (Physics.Raycast(transform.position, fwd, 5) && rotating == false) { 
            if (hit.transform.CompareTag("Wall"));
            {
                rotating = true;

                //controller.inputX = -controller.inputX;
                //controller.inputY = -controller.inputY;
                storedWalkSpeed = controller.walkSpeed;
                controller.walkSpeed = 0.0f;
 //               Vector3 targetRotate = (0, 180, 0);
                // this.transform.Rotate(0, 180, 0);
                //this.transform.Rotate(Vector3.left, );
                print("There is something in front of the object!");
            }
        }

        if (rotating == true)
        {
            rotation = rotateSpeed * Time.deltaTime;
            rotateCurrent = rotateCurrent + rotation;
           // this.transform.Rotate(0, rotation, 0);
            //this.transform.Rotate(Vector3.left, );
            //controller.walkSpeed = 0.0f;
          //  print("There is something in front of the object!");
            if (rotateCurrent >= rotateMax)
            {
                // update the rotation, we probably want slightly less
                float new_rotation = rotation - (rotateCurrent - rotateMax);
                this.transform.Rotate(0, new_rotation, 0);
                rotating = false;
                controller.walkSpeed = storedWalkSpeed;
                rotateCurrent = 0.0000f;
            }

           if (rotating == true)
            {
                this.transform.Rotate(0, rotation, 0);
            }

        }

    }
}