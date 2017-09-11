using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class exitt : MonoBehaviour
{
    public void doquit()
    {

        Application.Quit();
        Debug.Log("has quit the game");

    }
}