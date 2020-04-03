using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    public GameObject goalGameobject;
     private void OnMouseDrag()
    {
        Vector3 mousePosWorld3D = Input.mousePosition;
        mousePosWorld3D.z = transform.position.z - Camera.main.transform.position.z;
        mousePosWorld3D = Camera.main.ScreenToWorldPoint(mousePosWorld3D);

        transform.position = new Vector3(mousePosWorld3D.x,mousePosWorld3D.y,transform.position.z);
        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.Equals(goalGameobject))
        {
            Debug.Log("Win");
        }

    }
    
}
