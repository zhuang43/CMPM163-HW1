using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public float speed = 10f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
    }

    public void updateSpeed(float newSpeed) {
        speed = newSpeed;
        }

}
