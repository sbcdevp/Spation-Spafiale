using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Timer : MonoBehaviour
{
    public int scoreValue = 0;
    [SerializeField] private TextField timer;

    // Start is called before the first frame update
    void Start()
    {
        // timer = GetComponent<TextElement>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue += 1;
        timer.text = "Score: " + scoreValue;
        Debug.Log(timer);
    }
}
