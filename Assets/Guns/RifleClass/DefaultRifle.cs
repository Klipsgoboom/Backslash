using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultRifle : MonoBehaviour
{
    public Rigidbody2D rg;
public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 1;
     public float range = 500f;
    public LayerMask hitLayers;
    public bool safetyOff = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (safetyOff == true) {
                    rg.GetComponent<ParticleSystem>().Play();
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * bulletSpeed;
            }
        }
}

    void OnMouseDrag() {
        safetyOff = true;
     }
    void OnMouseUp() {
        safetyOff = false;
    }


}
