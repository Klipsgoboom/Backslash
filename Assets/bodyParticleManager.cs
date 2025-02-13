using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyParticleManager : MonoBehaviour
{


void OnCollisionEnter2D(Collision2D Collision2D) {
    if (Collision2D.relativeVelocity.magnitude > 10)
    GetComponent<ParticleSystem>().Play();
}
}
