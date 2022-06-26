using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float DoorOpenAngel = 90f; // angel when the door is open
    public float DoorCloseAngel = 0f; // start Angel
    public float speed_rotate = 2f;   // speed of the rootation

    public Canvas Safe_canvas;
    public GameObject _handofDoor;
    


    // Start is called before the first frame update
    void Start()
    {
        //_CrekDoor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GrapHandOfDoor();
        //OnGrapOver();
    }

    public void GrapHandOfDoor()
    {
        if (Player.targetGamobject.tag == "Door")
        {
            Debug.Log("Enter");
            if (Player._DistanceFromTarget <= 2)
            {

                Quaternion targetrotation = Quaternion.Euler(0, DoorOpenAngel, 0);
                Debug.Log(Player.targetGamobject.name);
                Player.targetGamobject.transform.localRotation = Quaternion.Slerp(Player.targetGamobject.transform.localRotation, targetrotation, speed_rotate * Time.deltaTime);
            }
            else
            {
                Quaternion targetrotation = Quaternion.Euler(0, 0, 0);
                Debug.Log(Player.targetGamobject.name);
                Player.targetGamobject.transform.localRotation = Quaternion.Slerp(Player.targetGamobject.transform.localRotation, targetrotation, speed_rotate * Time.deltaTime);
                // _Actiontext.SetActive(false);
                Debug.Log("over ");

            }
        }
        if (Player.targetGamobject.tag == "desk_Key")
        {
            if (Player._DistanceFromTarget <= 2)
            {

                if (Safe_canvas.gameObject)
                    Safe_canvas.gameObject.SetActive(true);
                Debug.Log("Enabled");
                // _CrekDoor.Play();

            }
            else
            {
                if (Safe_canvas.gameObject) Safe_canvas.gameObject.SetActive(false);
                Debug.Log("over ");

            }
        }
    }
   
}
