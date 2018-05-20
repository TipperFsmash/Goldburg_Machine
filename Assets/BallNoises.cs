using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallNoises : MonoBehaviour {

    public AudioSource Ball;
    public AudioClip CollisionSound;
    public AudioClip Collisionspin;

    void Start()
    {
        Ball = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Ball.PlayOneShot(CollisionSound);
        }

        if (collision.gameObject.tag == "spin slow")
        {
            Ball.PlayOneShot(Collisionspin);
        }
    }

}
