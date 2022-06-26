using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static GameObject targetGamobject;
    public static float _DistanceFromTarget;
    public float _Totarget;
   
    // Start is called before the first frame update
    void Start()
    {
        // flashlight_On = GetComponent<AudioSource>();
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        //flashlight_On.Play();
        //////////////How far away from things/////
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
        
            _Totarget = hit.distance;
            _DistanceFromTarget = _Totarget;
            if(hit.transform.gameObject)
                targetGamobject = hit.transform.gameObject;
          
        }

      
    }

}
