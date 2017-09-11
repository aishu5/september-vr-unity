using System.Collections;
using UnityEngine;

public class drag : MonoBehaviour {

    Vector3 dist;
    float posX;
    float PosY;
    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        PosY = Input.mousePosition.y - dist.y;
    }
    void OnMouseDrag()
    {
        Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - PosY, dist.z);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
    }
}





































