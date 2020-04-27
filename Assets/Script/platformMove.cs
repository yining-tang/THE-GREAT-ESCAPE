using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{
    public Transform movingPlat;
    public Transform post1;
    public Transform post2;
    public Vector3 newPost;
    public string currentstate;
    public float smooth;
    public float reset;
    // Start is called before the first frame update
    void Start()
    {
        TargetChange();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movingPlat.position = Vector3.Lerp(movingPlat.position, newPost, smooth * Time.deltaTime);
    }
    void TargetChange()
    {
        if (currentstate == "post1")
        {
            currentstate = "post2";
            newPost = post2.position;
        }
        else if(currentstate == "post2")
        {
            currentstate = "post1";
            newPost = post1.position;
        }
        else if(currentstate == "")
        {
            currentstate = "post2";
            newPost = post2.position;
        }
        Invoke("TargetChange", reset);
    }
        
    
}
