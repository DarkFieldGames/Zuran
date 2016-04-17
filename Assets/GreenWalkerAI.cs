using UnityEngine;
using System.Collections;

public class GreenWalkerAI : MonoBehaviour {

    void FixedUpdate()
    {
        FPSAI controller = this.GetComponent<FPSAI>();
        controller.walkSpeed = 0.0f;
    }
}
