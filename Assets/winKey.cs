using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winKey : MonoBehaviour
{
    public EventManager manager;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        manager.Finished();
       // GameObject.Find("player").SendMessage("Finished");
       // GameObject.Find("aj").SendMessage("AJ is done");
    }
}
