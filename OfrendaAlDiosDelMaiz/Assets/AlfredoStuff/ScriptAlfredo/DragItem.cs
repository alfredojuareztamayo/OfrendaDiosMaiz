using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragItem : MonoBehaviour
{//Variables para jalar gameobjct 
    RaycastHit2D hit;
    Camera cam;
    Vector3 pos;
    Vector3 mousePos;
    Transform focus;
   public bool isDrag; //variable para saber si esta siendo arrastrado

     void Start()
    {
        isDrag = false;
        cam = Camera.main;
    }
     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hit = Physics2D.GetRayIntersection(cam.ScreenPointToRay(Input.mousePosition));
            if (hit.collider != null)
            {
                focus = hit.transform;
                Debug.Log("te agarro = " + hit.collider.transform.name);
                isDrag = true;
            }
        }
        else if (Input.GetMouseButtonUp(0) && isDrag == true)
        {
            isDrag = false;
        }
        else if (isDrag == true)
        {
            mousePos = Input.mousePosition;
            mousePos.z = -cam.transform.position.z;
            pos = cam.ScreenToWorldPoint(mousePos);
            focus.position = new Vector3(pos.x, pos.y, 0);
        }
    }
   
}
