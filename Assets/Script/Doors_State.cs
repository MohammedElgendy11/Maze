using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors_State : MonoBehaviour
{
    Animator anim;
    bool dooropen;


    /* 
     * 
     *   public Vector3 endpos;
     private Vector3 startpos;
     private float delay = 0.0f;
     public float speed = 1.0f;
     public bool moving = false;
     public bool opening = true;
     * public int index = -1;
     public bool open = false;
     public float DoorOpenAngel = 90f; // angel when the door is open
     public float DoorCloseAngel = 0f; // start Angel
     public float speed_rotate = 2f;   // speed of the rootation

     public float t = -11.18f;*/

    // Start is called before the first frame update
    void Start()
    {
        //startpos = transform.position;
        dooropen = false;
        anim = GetComponent<Animator>();


    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Enter");
            dooropen = true;
            DoorControl("open");


        }
    }
    void OnTriggerExit(Collider col)
    {
        if (dooropen)
        {
            dooropen = false;
            DoorControl("close");

        }
    }
    void DoorControl(string direction)
    {
        anim.SetTrigger(direction);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

        /*
         * if (moving)
         {
             if (opening)
             {
                 move(endpos);
             }
             else
             {
                 move(startpos);
             }
         }

         * if (open) // open == true //
         {
             Quaternion targetrotation = Quaternion.Euler(0, DoorOpenAngel, 0);
             transform.localPosition = new Vector3(0, 0, 0);
             transform.position = Vector3.Lerp(t, y, z);
             transform.localRotation = Quaternion.Slerp(transform.localRotation, targetrotation, speed_rotate * Time.deltaTime);
         }

         else
         {
             Quaternion targetrotation2 = Quaternion.Euler(0, DoorCloseAngel, 0);
             transform.localRotation = Quaternion.Slerp(transform.localRotation, targetrotation2, speed_rotate * Time.deltaTime);
         }*/
    
    /* public void ChangDoorState()
     {
         open = !open;

     }*/

   /* public void move(Vector3 goalpos)
    {
        float dis = Vector3.Distance(transform.position, goalpos);
        if (dis> 0.1f)
        {
            transform.position = Vector3.Lerp(transform.position, goalpos, speed * Time.deltaTime);

        }
        else
        {
            moving = false;
            opening = true;

        }
    }
    public bool Moving
    {
        get { return moving; }
        set { moving = value; }
    }
}*/
