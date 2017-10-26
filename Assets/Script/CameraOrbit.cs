﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{

    public Transform target;

    public float horizMove = 45f;
    public float vertMove = 15f;

    public float updownAmount = 10f;

    public void MoveHorizontal(bool left)
    {
        float dir = 1;
        if (!left)
            dir *= -1;
        transform.RotateAround(target.position, Vector3.up, horizMove * dir);

    }
    public void MoveVertical(bool up)
    {
        float dir = 1;
        if (!up)
            dir *= -1;
        transform.RotateAround(target.position, transform.TransformDirection(Vector3.right) , vertMove * dir);

    }
}