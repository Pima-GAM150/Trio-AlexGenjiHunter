using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate_Z : MonoBehaviour, IScrollable {

    public Transform objectToRotate;
    public float minAngle_negative;
    public float maxAngle_positive;
    public float initialAngle;
    private float currentAngle;
    private float scale = 15; //rotation multiplier
    
    public void Start() {
        objectToRotate.transform.rotation = Quaternion.Euler(new Vector3(0, 0, initialAngle));
    }

    public void OnScrolled(float scrollAmount) {
        if (scrollAmount != 0.0f) {//only update when mouse wheel'd
            currentAngle += scrollAmount * scale;
            if (currentAngle < minAngle_negative) currentAngle = minAngle_negative;
            if (initialAngle > maxAngle_positive) currentAngle = maxAngle_positive;
            objectToRotate.transform.rotation = Quaternion.Euler(new Vector3(0, 0, currentAngle));
        }
    }

}