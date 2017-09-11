using System.Collections;

using UnityEngine;

public class zoo22 : MonoBehaviour
{

    public float movespeed = 35.0f;
    //you need to say how far from the object the camera will stop
    public float minimumDistanceFromTarget = 5f;
    public GameObject targetobject;
    private bool movingtowardstarget = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            if (movingtowardstarget == true)
            {
                movingtowardstarget = false;
            }
            else
            {

                movingtowardstarget = true;

            }
        }

        if (movingtowardstarget)
        {
            movetowardstarget(targetobject);
        }

    }

    public void movetowardstarget(GameObject target)
    {
        if(Vector3.Distance(transform.position, target.transform.position) > minimumDistanceFromTarget) //we move only if we are further than the minimum distance
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, movespeed * Time.deltaTime);
        } else //otherwise, we stop moving
        {
            movingtowardstarget = false;
        }
    }
}