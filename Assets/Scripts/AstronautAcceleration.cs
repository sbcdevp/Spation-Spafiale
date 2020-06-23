using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautAcceleration : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float yFallValue = 500f;
    Vector3 _moveDirection;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection.x = Input.GetAxis("Horizontal");
        _moveDirection.z = Input.GetAxis("Vertical");
        // yFallValue -= 1;
        transform.position = new Vector3(transform.position.x + _moveDirection.x, transform.position.y, transform.position.z + _moveDirection.z);
        
    }

}
