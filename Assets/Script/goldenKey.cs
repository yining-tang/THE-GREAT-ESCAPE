using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenKey : MonoBehaviour
{
    public GameObject Goldenkey;
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
}
