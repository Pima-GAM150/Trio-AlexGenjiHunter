using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBend : MonoBehaviour, IScrollable {

    public Transform hingeToBend;
    public float initialAngle;

    public void Start() {
        hingeToBend.transform.rotation = Quaternion.Euler(new Vector3(0, initialAngle));
    }

    public void Update() {

    }

    public void OnScrolled(float scrollAmount) {
        if (scrollAmount != 0.0f) {
            initialAngle += scrollAmount * 15;
            if (initialAngle < -90) initialAngle = -90;
            if (initialAngle > 90) initialAngle = 90;
            hingeToBend.transform.rotation = Quaternion.Euler(new Vector3(0, initialAngle));
            /*hingeAngles.min = pos;
            hingeAngles.max = pos;
            hingeToBend.limits = hingeAngles;
            //hingeToBend.useLimits = true;*/
        }
    }
    
}
