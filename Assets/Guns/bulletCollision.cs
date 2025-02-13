using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollision : MonoBehaviour
{
public Rigidbody2D rg;


void OnCollisionEnter2D(Collision2D Collision2D) {
Destroy(rg);
}
}
