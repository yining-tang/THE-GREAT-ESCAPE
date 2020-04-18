using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
	public Transform target;
	private float speed;
	public GameObject explosion;
    private AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
        audio1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    /*
    void OnCollisionEnter(Collision col) {
    	if(col.gameObject.tag == "Bullet") {
            audio1.Play();
            Destroy(col.gameObject);
    		Instantiate(explosion, transform.position, transform.rotation);
    		Destroy(this);
    		Destroy(gameObject);
    	}
    }*/
}







