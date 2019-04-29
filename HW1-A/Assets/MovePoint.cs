using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoint : MonoBehaviour
{
    private Vector3 StartPos;
    private float ElapsedTime = 100f;
    void Start()
    {
        StartPos = transform.position;
    }

    void Update()
    {
        ElapsedTime += Time.deltaTime;
        Vector3 newPos = StartPos;
        newPos.y += Mathf.Sin(ElapsedTime);

        transform.position = newPos;
    }
}
