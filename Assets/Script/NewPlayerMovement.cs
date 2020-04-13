using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{
    public float movespeed;
   // public Rigidbody rbody;
    public float jumpforce;
    public CharacterController controller;
    private Vector3 movedirection;
    public float gravityscale;
   public Animator anim;
    public Transform pivot;
    public float rotatespeed;
    public GameObject player;
    void Start()
    {
        // rbody = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //rbody.velocity = new Vector3(Input.GetAxis("Horizontal") * movespeed, rbody.velocity.y, Input.GetAxis("Vertical") * movespeed);
        //if(Input.GetButtonDown("Jump"))
        //{
        //    rbody.velocity = new Vector3(rbody.velocity.x, jumpforce, rbody.velocity.z);
        //}
        //movedirection = new Vector3(Input.GetAxis("Horizontal") * movespeed, movedirection.y, Input.GetAxis("Vertical") * movespeed);
        float Yvalue = movedirection.y;
        movedirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        movedirection = movedirection.normalized * movespeed;
        movedirection.y = Yvalue;
        if (controller.isGrounded)
        {
            movedirection.y = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                movedirection.y = jumpforce;
            }
        }
        movedirection.y = movedirection.y + (Physics.gravity.y*gravityscale*Time.deltaTime);
        controller.Move(movedirection * Time.deltaTime);
        //moveplayer in direction based on camera view
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0 )
        {
            transform.rotation = Quaternion.Euler(0f, pivot.rotation.eulerAngles.y, 0f);
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(movedirection.x, 0f, movedirection.z));
            player.transform.rotation = Quaternion.Slerp(player.transform.rotation, newRotation, rotatespeed * Time.deltaTime);
        }
        anim.SetBool("isGrounded", controller.isGrounded);
        anim.SetFloat("speed", (Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"))));
    }
}
