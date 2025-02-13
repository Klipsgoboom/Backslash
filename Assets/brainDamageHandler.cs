using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brainDamageHandler : MonoBehaviour
{
            bool dead;
    void Start() {
            GetComponent<HingeJoint2D>().useLimits = true;


    GetComponent<HingeJoint2D>().limits = new JointAngleLimits2D { min = 0, max = 0 };
    }

        void OnCollisionEnter2D(Collision2D Collision2D) {
            if (Collision2D.relativeVelocity.magnitude > 4) {
                    GetComponent<HingeJoint2D>().useLimits = false;
                    Debug.Log("Dead");
                    GameObject.Find("Ragdoll").GetComponent<StickmanController>().dead = true;
            }
        }
    
}
