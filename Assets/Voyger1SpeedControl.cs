using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Voyger1SpeedControl : MonoBehaviour
{
    public float WheninTheCollider;
    public float whenOutOfCollider;

    private bool isEnter;
    private bool isExit;

    public PathCreator pathCreator;
    public EndOfPathInstruction endOfPathInstruction;
    public float speed = 5;
    float distanceTravelled;

    private void Awake()
    {
        var boxCollider = gameObject.AddComponent<BoxCollider>();
        isEnter = true;
        isExit = true;

    }

    void Update()
    {
        if (pathCreator != null)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
            // transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isEnter)
        {
            speed = WheninTheCollider;
            Debug.Log("in");
            isEnter = false;
            isExit = true;
        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (isExit)
        {
            speed = whenOutOfCollider;
            Debug.Log("Exit");
            isExit = false;
            isEnter = true;
        }


    }
}
