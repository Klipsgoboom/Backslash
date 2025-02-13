using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButtonClicked : MonoBehaviour
{
void Update() {
    if (Input.GetKey(KeyCode.Mouse0)) {
        SceneManager.LoadScene(1);
    }
}
}