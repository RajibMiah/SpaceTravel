using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Voyger1SpeedControl : MonoBehaviour
{
    //public float WheninTheCollider;
    public float whenOutOfCollider;



    public PathCreator pathCreator;
    public EndOfPathInstruction endOfPathInstruction;
    public float speed;
    float distanceTravelled;

    private void Start()
    {
        var boxCollider = gameObject.AddComponent<BoxCollider>();
        speed = 0f;

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

        if (other.gameObject.tag == "Earth")
        {
            speed = 1f;
            //Debug.Log("earth speed" + speed);
        }
        else if (other.gameObject.tag == "Mars")
        {
            speed = 0.05f;
             Debug.Log("mars speed" + speed);
        }
        else if (other.gameObject.tag == "Jupiter")
        {
            speed = 2f;
            // Debug.Log("jupiter speed" + speed);
        }
        else if (other.gameObject.tag == "Saturn")
        {
            speed = 1f;
            // Debug.Log("Saturn speed" + speed);
        }
        else if (other.gameObject.tag == "Uranus")
        {
            speed = 1f;
            // Debug.Log("Uranus speed" + speed);
        }
        else if (other.gameObject.tag == "Neptune")
        {
            speed = 1f;
            // Debug.Log("Neptune speed" + speed);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        speed = whenOutOfCollider;
    }

}
