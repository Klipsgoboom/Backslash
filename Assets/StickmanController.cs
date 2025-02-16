using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanController : MonoBehaviour
{

    public _Muscle[] muscles;
    public bool dead;

    private void Update()
    {   
        if (dead == false) {
        foreach (_Muscle muscle in muscles)
        {
                muscle.ActivateMuscle();    
        }
        }
    }
}
    [System.Serializable]
public class _Muscle 
{ 
    public Rigidbody2D bone;
    public float restRotation;
    public float force;
    

    public void ActivateMuscle()
    {   
            bone.MoveRotation(Mathf.LerpAngle(bone.rotation, restRotation, force * Time.deltaTime)); 
    }
}