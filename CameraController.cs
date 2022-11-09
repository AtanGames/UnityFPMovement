using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform head;

    private void Start()
    {
        head = Movement.Instance.head;
    }

    private void Update()
    {
        transform.position = head.position;
    }
}
