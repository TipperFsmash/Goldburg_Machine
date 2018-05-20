using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public Transform target;

    public float smoothspeed = 0.125f;
    public Vector3 offset;

    void LateUpdate ()
    {
        transform.position = target.position + offset;
    }
    
}
