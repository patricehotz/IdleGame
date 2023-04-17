using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Camera camera;
    private Vector3 dragOrigin;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        PanCamera();
    }
    private void PanCamera()
    {
        //save position of mouse in world space when drag starts (first time clicked)
        
        if(Input.GetMouseButtonDown(0))
            dragOrigin = camera.ScreenToWorldPoint(Input.mousePosition);

        //calculate distance between drag origin and new position if it is still held down
        if(Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - camera.ScreenToWorldPoint(Input.mousePosition);
            
            print("origin " + dragOrigin + " newPosition " + camera.ScreenToWorldPoint(Input.mousePosition) + " = difference " + difference);

            //move the camera by that distance, but only in the y axis
            camera.transform.position += new Vector3(0, difference.y, 0);
        }
    }
}
