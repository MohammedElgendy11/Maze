using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeCanvas : MonoBehaviour
{
    public GameObject _handofDoor;

    public Animation deskAnim;
    public Canvas safecanvas;
    bool opened;
    private int num1 = 0;
    private int num2 = 0;
    private int num3 = 0;
    private int num4 = 0;

    public Text textNum1;
    public Text textNum2;
    public Text textNum3;
    public Text textNum4;

    public int[] numbers;
    // Start is called before the first frame update
    void Start()
    {
        safecanvas.gameObject.SetActive(false);
        //Debug.Log("Canvas");
        opened = false;
    }

    // Update is called once per frame
    void Update()
    {  
        
        
       
    }      
    void Check()
    {
        //check if we put a right code == 4128
        Debug.Log(textNum4.text);
        if (num1==numbers[0] && num2== numbers[1] && num3 == numbers[2] && num4 == numbers[3] )
        //if (textNum1.text == "1")
        {
            Debug.Log("Done");
            opened = true;
            safecanvas.gameObject.SetActive(false);
            UnlockSafe();
        }
    }
    public void UnlockSafe()
    {

        
        //_handofDoor.GetComponent<BoxCollider>().enabled = false;
        deskAnim.GetComponent<Animation>().Play();


    }
    public void Increase(int _num)
    {
        
        
        if (_num == 1)
        {
            num1++;
            textNum1.text = num1.ToString();
            if (_num > 9)
            {
                num1 = 1;
                textNum1.text = num1.ToString();

            }

        }
        if (_num == 2)
        {
            num2++;
            textNum2.text = num2.ToString();
            if (_num > 9)
            {
                num2 = 1;
                textNum2.text = num2.ToString();

            }
        }
        if (_num == 3)
        {
            num3++;
            textNum3.text = num3.ToString();
            if (_num > 9)
            {
                num3 = 1;
                textNum3.text = num3.ToString();
            }
        }
        if (_num == 4)
        {
            num4++;
            textNum4.text = num4.ToString();
            if (_num > 9)
            {
                num4 = 1;
                textNum4.text = num4.ToString();
            }
        }
        Debug.Log("increase");
        Check();
    }
    public void Decrease(int _num)
    {
        if (_num == 1)
        {
            num1--;
            textNum1.text = num1.ToString();
            if (_num < 1)
            {
                num1 = 9;
                textNum1.text = num1.ToString();

            }

        }
        if (_num == 2)
        {
            num2--;
            textNum2.text = num2.ToString();
            if (_num < 1)
            {
                num2 = 9;
                textNum2.text = num2.ToString();

            }
        }
        if (_num == 3)
        {
            num3--;
            textNum3.text = num3.ToString();
            if (_num < 1)
            {
                num3 = 9;
                textNum3.text = num3.ToString();

            }
        }
        if (_num == 4)
        {
            num4--;
            textNum4.text = num4.ToString();
            if (_num < 1)
            {
                num4 = 9;
                textNum4.text = num4.ToString();

            }
        }
    }
}
