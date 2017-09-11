using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class blue : MonoBehaviour
{




    public GameObject myGo;
    public Text myText;

    float roll, pitch;


    void Update()
    {
        roll = Input.GetAxis("Horizontal");     //joystick horizontal
        pitch = Input.GetAxis("Vertical");      //joystick vertical

        myGo.transform.position += new Vector3(roll * 0.1f, pitch * 0.1f, 0);

        //Bluetooth Controller Joystick
        if (Input.GetAxis("Vertical") > 0)
        {
            ButtonName("Up Pressed");
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            ButtonName("Down Pressed");
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            ButtonName("Right Pressed");
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            ButtonName("Left Pressed");
        }




        // Bluetooth Controller Buttons VR_Lioneye
        if (Input.GetButtonDown("A"))
        {
            ButtonName("A");
        }
        if (Input.GetButtonDown("B"))
        {
            ButtonName("B");
        }
        if (Input.GetButtonDown("C"))
        {
            ButtonName("C");
        }
        if (Input.GetButtonDown("D"))
        {
            ButtonName("D");
        }
        if (Input.GetButtonDown("OnOff"))
        {
            ButtonName("OnOff");
            myGo.transform.position = new Vector3(0f, 0f, 0f);      //reset position
        }

    }

    public void ButtonName(string ButtonName)
    {
        myText.text = ButtonName;
    }
}
