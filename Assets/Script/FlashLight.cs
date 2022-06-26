using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;

public class FlashLight : MonoBehaviour
{
    public GameObject ON;
    public GameObject Off;
    bool IsOn = false;
    GameObject torchGrabbed;
    
    // Start is called before the first frame update
    void Start()
    {
        ON.SetActive(false);
        Off.SetActive(true);
        IsOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Trigger))
        {

            Collider[] cols = Physics.OverlapSphere(this.transform.position, 0.3f);
            if (cols.Length > 0 && cols[0].gameObject.tag == "Flash")
            {
                Debug.Log("Grap");
                torchGrabbed = cols[0].gameObject;
                Debug.Log("Anything");
            }
        }
        if (torchGrabbed)
        {

            torchGrabbed.transform.parent = this.transform;

            if (!IsOn)
            {
                ON.SetActive(true);
                Off.SetActive(false);
            }
        }

        IsOn = !IsOn;

        if (ViveInput.GetPressUp(HandRole.RightHand, ControllerButton.Trigger))
        {
            if (torchGrabbed)
            {
                ON.SetActive(false);
                Off.SetActive(true);
                torchGrabbed.transform.parent = null;
                torchGrabbed = null;
            }
        }
    }
}

    
    
    
    
    
