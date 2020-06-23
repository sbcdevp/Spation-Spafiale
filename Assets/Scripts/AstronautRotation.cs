using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautRotation : MonoBehaviour
{
    // Start is called before the first frame update
    float smooth = 5.0f;
    float tiltAngleX = -60.0f;
    float tiltAngleZ = 60.0f;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        UpdateRotation();
    }
    void UpdateRotation() 
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngleZ;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngleX;

        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);


        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

    }
}
