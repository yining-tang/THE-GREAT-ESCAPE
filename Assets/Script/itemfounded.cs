using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemfounded : MonoBehaviour
{
    public EventManager manager;
    private AudioSource audio;
    // public enemycounter Mycounter;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this);
            Destroy(gameObject);
            audio.Play();
            manager.counter++;
            //Mycounter.itemfound = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(10*Time.deltaTime, 10*Time.deltaTime, 0 ,Space.World);
    }
}
