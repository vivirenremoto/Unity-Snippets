using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public float speed = 120;
    public bool random_rotation = true;
    
    void Start()
    {
        if( random_rotation ){
            transform.rotation = Quaternion.Euler(0, Random.Range(0,360) ,0);   
        }
    }

    void Update()
    {
        transform.RotateAround(transform.position, Vector3.down, speed * Time.deltaTime);
    }
}
