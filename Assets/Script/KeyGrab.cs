using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;

public class KeyGrab : MonoBehaviour
{

    GameObject KeyGrapped;
     public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

        rb.useGravity = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Trigger))
        {

            Collider[] cols = Physics.OverlapSphere(this.transform.position, 0.3f);
            if (cols.Length > 0 && cols[0].gameObject.tag == "Grab")
            {
                KeyGrapped = cols[0].gameObject;  
                
            }
        }
        if (KeyGrapped)
        {

            KeyGrapped.transform.parent = this.transform;

        }

        if (ViveInput.GetPressUp(HandRole.RightHand, ControllerButton.Trigger))
        {
            if (KeyGrapped)
            {

                KeyGrapped.transform.parent = null;
                KeyGrapped = null;
                //KeyGrapped.GetComponent<Rigidbody>().useGravity = true;
                rb.useGravity = true;

            }
        }
    }
}
