using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smooothcamerafollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed= 10f;
    public Vector3 offset;
    public bool isfollowing;

    private void Start()
    {
        
        isfollowing = true;
    }

    void FixedUpdate()
    {
        if (isfollowing == true)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
        
    }
	
}
