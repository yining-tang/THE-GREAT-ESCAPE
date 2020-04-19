using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenKey : MonoBehaviour
{
    public GameObject Goldenkey;
    public EventManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoldenKeyMake()
    {
        Instantiate(Goldenkey, transform.position, Quaternion.identity);
    }
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        manager.Finished();
        // GameObject.Find("player").SendMessage("Finished");
        // GameObject.Find("aj").SendMessage("AJ is done");
    }
}
