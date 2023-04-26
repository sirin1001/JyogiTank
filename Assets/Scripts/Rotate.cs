using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float RotSpeed = 10f;
    float elevationAngle    = 80f;   //‹ÂŠp
    float depressionAngle   = -20f;    //˜ëŠp 

    void Update()
    {
        float angleY = transform.localEulerAngles.y;

        if(Input.GetAxis("Horizontal") > 0)
        {
            angleY = 0;
        } 
        if(Input.GetAxis("Horizontal") < 0)
        {
            angleY = 180;
        }
     
        transform.Rotate(0f, 0f, RotSpeed * Time.deltaTime * Input.GetAxis("Vertical"));

        float angleZ = transform.localEulerAngles.z;
        if (angleZ > 180)
        {
            angleZ -= 360;
        }
        angleZ = Mathf.Clamp(angleZ, depressionAngle, elevationAngle);

        transform.localEulerAngles = new Vector3(0,angleY,angleZ);
    }
}
