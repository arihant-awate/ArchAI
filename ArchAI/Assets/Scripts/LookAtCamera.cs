using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField] Transform cam;
    [SerializeField] GameObject camera;
    void Start()
    {
       camera.transform.localRotation= Quaternion.Euler(0f, 90f, 0f);
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0f, cam.eulerAngles.y, 0f);
    }
}
