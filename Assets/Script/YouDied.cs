using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouDied : MonoBehaviour
{
    public EventManager manager;
    public Collider collider;
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        //collider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            manager.Dead();
            source.Play();
        }
    }
}
