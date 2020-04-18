using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winKey : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("player").SendMessage("Finished");
        GameObject.Find("aj").SendMessage("AJ is done");
    }
}
