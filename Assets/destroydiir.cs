using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroydiir : MonoBehaviour {

    public AudioSource Door;
    public AudioClip CollisionSound;


    void Start()
    {
       
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Door")
        {
           Destroy (collision.gameObject);
        }

        if (collision.gameObject.tag == "Door")
        {
            Door.PlayOneShot(CollisionSound);
        }

    }

}
