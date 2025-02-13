using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Rope : MonoBehaviour
{
 public Camera mainCamera;
    public LineRenderer _lineRenderer;
    public DistanceJoint2D _distanceJoint;

    Rigidbody2D rb;

    public bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        _distanceJoint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_distanceJoint.enabled) 
        {
            _lineRenderer.SetPosition(1, transform.position);
            
        }
                 if (Input.GetKeyDown(KeyCode.Mouse1)) {
                        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
         if (Input.GetMouseButtonUp(1))
        {
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            _lineRenderer.SetPosition(0, mousePos);
            _lineRenderer.SetPosition(1, transform.position);
            _distanceJoint.connectedAnchor = mousePos;
            _distanceJoint.enabled = true;
            _lineRenderer.enabled = true;
            clicked = true;
        
        }
                rb = GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.None;
    }
    }


    }