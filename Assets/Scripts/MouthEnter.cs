using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//DoTween for the win
public class MouthEnter : MonoBehaviour
{

    [SerializeField] private GameObject mouth;

    private Vector3 _defaultPosition;

    private void Start()
    {
        _defaultPosition = mouth.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(mouth.transform.position);
    }
}