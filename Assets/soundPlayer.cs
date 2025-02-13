using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlayer : MonoBehaviour
{

    public float requiredVelocity = 900;
    Rigidbody rb;

    public AudioSource source;
    public AudioClip clip;
private void OnCollisionEnter2D(Collision2D Collision2D) {

       if (Collision2D.relativeVelocity.magnitude > requiredVelocity) {
        source.PlayOneShot(clip);

       }
       
    }
}