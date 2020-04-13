using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public bool useOffsetvalue;
    public float rotatespeed;
    public Transform pivot;
    public float maxview;
    public float minview;
    public bool inverY;
    // Start is called before the first frame update
    void Start()
    {
        if (!useOffsetvalue)
        {
            offset = player.position - transform.position;
        }
        pivot.transform.position = player.transform.position;
        //pivot.transform.parent = player.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        pivot.transform.position = player.transform.position;
        pivot.transform.parent = null;

        //player rotate
        float horizontal = Input.GetAxis("Mouse X") * rotatespeed;
        pivot.Rotate(0, horizontal, 0);

        //pivot movement

        float vertical = Input.GetAxis("Mouse Y") * rotatespeed;
        
        if(inverY)
        {
        pivot.Rotate(vertical, 0, 0);
        }
        else
        {
            pivot.Rotate(-vertical, 0, 0);
        }
        //limit the movement
        if (pivot.rotation.eulerAngles.x > maxview && pivot.rotation.eulerAngles.x < 180f)
        {
            pivot.rotation = Quaternion.Euler(45f, 0, 0);
        }
        if (pivot.rotation.eulerAngles.x > 180f && pivot.rotation.eulerAngles.x < 360f + minview)
        {
            pivot.rotation = Quaternion.Euler(360f + minview, 0, 0);
        }
            //camera rotate
            float Yangle = pivot.eulerAngles.y;
        float Xangle = pivot.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(Xangle, Yangle, 0);
        transform.position = player.position - (rotation * offset);

        //transform.position = player.position - offset;
        if (transform.position.y < player.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }



        transform.LookAt(player);
    }
}
