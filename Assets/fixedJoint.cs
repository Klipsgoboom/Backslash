using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixedJoint : MonoBehaviour
{
    private GameObject firstObject;
    private GameObject secondObject;
    private LineRenderer lineRenderer;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                if (firstObject == null)
                {
                    firstObject = hit.collider.gameObject;
                }
                else
                {
                    secondObject = hit.collider.gameObject;
                    CreateFixedJoint();
                    firstObject = null;
                    secondObject = null;
                }
            }
        }
    }

    void CreateFixedJoint()
    {

        FixedJoint2D fixedJoint = firstObject.AddComponent<FixedJoint2D>();
        fixedJoint.connectedBody = secondObject.GetComponent<Rigidbody2D>();
        lineRenderer = firstObject.GetComponent<LineRenderer>();
        lineRenderer.useWorldSpace = false;
        lineRenderer.SetPositions(new Vector3[] { firstObject.transform.position, secondObject.transform.position });
    
    }
}
