using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotateCC : MonoBehaviour
{

    public float speed = 0;
    private float currentAngle;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentAngle -= speed;
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, currentAngle));
    }
}
