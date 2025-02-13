using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultPistol : MonoBehaviour
{
public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
     public float range = 100f;
    public LayerMask hitLayers;
    public bool safetyOff = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (safetyOff == true) {
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
