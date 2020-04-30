using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAndRespawn : MonoBehaviour
{
    public EventManager manager;
    public Collider collider;
    // public enemycounter Mycounter;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            manager.Lose();
            //Mycounter.itemfound = true;
        }
    }

}
