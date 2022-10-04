using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour
{

    public float speed = -1;

    void Start()
    {
        RenderSettings.skybox.SetFloat("_Rotation", 0);
    }

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * speed);
    }

}
