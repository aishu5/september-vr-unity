using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomperfect : MonoBehaviour {

    //you need to start naming your variables better, more descriptively,
    //it helps with coming up with the right solution
    public int zoomedFOV = 20;
    public int normalFOV = 60;
    public float zoomSpeed = 5; //by how much we change the FOV each SECOND

    private bool isZooming = false;
    private float zoomDirection = 1; // <- i told you that you can switch between zooming in/out with one +/- sign, this is it. look at how this is set and then used in the update function
    private float percentZoomedIn = 0; //how much percent are we between the zoomedFOV and normalFOV? this value only makes sense in the range between 0 (0%) and 1 (100%)

    //STORE the main camera in a variable because doing Camera.main or GetComponent each frame is slow
    Camera mainCam;

	// Use this for initialization
	void Start () {
        mainCam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        { //we zoom in by holding the left mouse button
            iszoomed = true; 
            zoomDirection = 1; //zoomDirection holds the plus sign, will thus move our percentZoomedIn towards 1 (that's 100%)
        } else if(Input.GetMouseButton(1))
        { //zoom out by holding the right mouse button
            isZooming = true;
            zoomDirection = -1; //zoomDirection holds the minus sign, will thus move our percentZoomedIn towards 0 (that's 0%)
        } else
        { //if neither button is held, we don't change the zoom level
            isZooming = false;
        }


        if (isZooming)
        {
            if(Mathf.Abs(percentZoomedIn) <= 1 && percentZoomedIn >= 0) //only change zoom percentage if it's within reasonable range
            {
                percentZoomedIn += zoomSpeed * Time.deltaTime * zoomDirection; //zoom speed is in seconds, Time.deltaTime is seconds per frame, so zoomSpeed * Time.deltaTime makes this run for X seconds until we get through the whole 1
                //zoomDirection changes whether this line does "percentZoomedIn -= fovChange" or whether it does "percentZoomedIn += fovChange"
            }

            mainCam.fieldOfView = Mathf.Lerp(normalFOV, zoomedFOV, percentZoomedIn); //actually set the degree to which we are zoomed in on the camera.
        }
	}
}
