
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss : MonoBehaviour
{
    Camera cam;
    Vector3 lastvp;

    // Use this for initialization
    void Start()
    {

    }
    private void awake()
    {
        lastvp = transform.position;
        cam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            this.transform.position += Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition + new Vector3(0f,0f,10f)));
            lastvp = this.transform.position;

        }
    }
}

