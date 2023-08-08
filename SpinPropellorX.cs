using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellorX : MonoBehaviour
{
    //Default to 30f for a more realistic spin speed
    private float speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     transform.Rotate(Vector3.forward * speed);   
    }
}
