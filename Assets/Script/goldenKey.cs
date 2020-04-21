using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenKey : MonoBehaviour
{
    public GameObject Goldenkey;
    public EventManager manager;

    public Collider collider;
    public AudioSource source;
    
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
        //manager.Finished();
        // GameObject.Find("player").SendMessage("Finished");
        // GameObject.Find("aj").SendMessage("AJ is done");
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            string name = "GoodGoldKey(Clone)";
            GameObject go = GameObject.Find(name);
            //if the tree exist then destroy it
            if (go)
            {
                source.Play();
                Destroy(go.gameObject);
            }
            Destroy(this);

            manager.Win();

            //Mycounter.itemfound = true;
        }
        
    }
}
