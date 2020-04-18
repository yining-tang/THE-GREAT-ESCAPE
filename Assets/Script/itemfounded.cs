using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemfounded : MonoBehaviour
{
    public EventManager manager;
    public AudioSource source;
    // public enemycounter Mycounter;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            manager.counter++;
            source.Play();
            
            Destroy(gameObject);
           Destroy(this);
            
            //Mycounter.itemfound = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(10*Time.deltaTime, 10*Time.deltaTime, 0 ,Space.World);
    }
}
