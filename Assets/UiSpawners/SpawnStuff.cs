using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnStuff : MonoBehaviour
{
    public GameObject brickPrefab;
    public GameObject concretePrefab;
    public GameObject gunPrefab;
    public GameObject akPrefab;

    private Vector3 mousePos;
    public bool bricks;
    public bool concrete;
    public bool gun;
    public bool ak;

    public Button brickbtn;
    public Button concretebtn;
    public Button gunbtn;
    public Button akbtn;
    public Button revive;
    public Button quit;

    // Update is called once per frame

void Start() {
            brickbtn.onClick.AddListener(BRICKBTN);
            concretebtn.onClick.AddListener(CONCRETEBTN);
            gunbtn.onClick.AddListener(GUNBTN);
            akbtn.onClick.AddListener(AKBTN);
            revive.onClick.AddListener(REVIVE);
            quit.onClick.AddListener(QUIT);
}

    void Update()
{




if (Application.isMobilePlatform)
{
if (bricks == true) {
        
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(brickPrefab, mousePos, Quaternion.identity);
        }
                if (concrete == true) {
        
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(concretePrefab, mousePos, Quaternion.identity);
        }
}
else
{
                if(Input.GetKeyDown(KeyCode.E)) {
        if (bricks == true) {
        
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(brickPrefab, mousePos, Quaternion.identity);
        }
                if (concrete == true) {
        
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(concretePrefab, mousePos, Quaternion.identity);
        }
                        if (gun == true) {
        
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(gunPrefab, mousePos, Quaternion.identity);
        }
                                if (ak == true) {
        
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(akPrefab, mousePos, Quaternion.identity);
        }
    }
}


}

void QUIT() {
Application.Quit();
}

void REVIVE() {
GameObject.Find("Ragdoll").GetComponent<StickmanController>().dead = false;
}


    void BRICKBTN() {
if (Application.isMobilePlatform) {
    mousePos = Camera.main.transform.position;
    mousePos.z = 0;
    Instantiate(brickPrefab, mousePos, Quaternion.identity);
}

else {
    bricks = true;
    concrete = false;
    gun = false;
    ak = false;
}
}

void CONCRETEBTN() {
if (Application.isMobilePlatform)
{
    mousePos = Camera.main.transform.position;
    mousePos.z = 0;
    Instantiate(concretePrefab, mousePos, Quaternion.identity);
}
else
{
bricks = false;
concrete = true;
gun = false;
ak = false;
    }

}
        void GUNBTN() {
            if (Application.isMobilePlatform)
{
            mousePos = Camera.main.transform.position;
            mousePos.z = 0;

            Instantiate(gunPrefab, mousePos, Quaternion.identity);
}
else
{
bricks = false;
concrete = false;
gun = true;
ak = false;
    }

}
        void AKBTN() {
            if (Application.isMobilePlatform)
{
            mousePos = Camera.main.transform.position;
            mousePos.z = 0;

            Instantiate(akPrefab, mousePos, Quaternion.identity);
}
else
{
bricks = false;
concrete = false;
gun = false;
ak = true;
    }

}
}
