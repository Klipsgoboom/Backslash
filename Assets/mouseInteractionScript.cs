using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class mouseInteractionScript : MonoBehaviour
{
public float force = 10;
public Rigidbody2D rg;
public Transform tr;
public LayerMask layerMask;
public float decelerationRate = 1f;
public bool enablemove = false;

    public Button turn1;
    public Button turn2;

    public float rotationSpeed = 50f;

void start() {
                turn1.onClick.AddListener(TONEBTN);
            turn2.onClick.AddListener(TTWOBTN);
}

void Update() {

                        Vector3 mousePos = Input.mousePosition;


if (enablemove == true) {
    
    if (Input.GetKey(KeyCode.Mouse0) ) {
        
                    Vector3 velocity = rg.velocity;
            velocity *= 1 - decelerationRate;
            rg.velocity = velocity;
    //            Vector3 mousePos = Input.mousePosition;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(rg.transform.position);
        float distance = Vector3.Distance(mousePos, objectPos);



        Vector2 dir = rg.position - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

        rg.AddForce(-dir * distance );

    }
}

if (Input.GetKey(KeyCode.A))
        {
            if (enablemove == true) {
                rg.velocity = Vector2.zero;
rg.angularVelocity = 0f;
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);



        }
        }
        else if (Input.GetKey(KeyCode.D))
                    if (enablemove == true) {
        {
            rg.velocity = Vector2.zero;
rg.angularVelocity = 0f;
            transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
        }
}



}



    void OnMouseDrag() {
        enablemove = true;

     }
    void OnMouseUp() {
        enablemove = false;
    }


    


    void TONEBTN() {
            if (enablemove == true) {
                rg.velocity = Vector2.zero;
rg.angularVelocity = 0f;
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);



        }
    }

        void TTWOBTN() {
                    if (enablemove == true) {
            rg.velocity = Vector2.zero;
rg.angularVelocity = 0f;
            transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
        }
    }

}



