using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBend : MonoBehaviour, IScrollable {

    public HingeJoint HingeToBend;
    private JointLimits joint;
    public Transform pos;

    public void Start() {

    }

    public void OnScrolled(float scrollAmount) {
        //Debug.Log(scrollAmount);
        //joint = HingeToBend.limits;
        //if (joint.min <= 0 && joint.min >= -90) {
        //    joint.min -= scrollAmount * 10;
        //    joint.max -= scrollAmount * 10;
        //}
        //else {
        //    joint.min = 0f;
        //    joint.max = 0f;
        //    HingeToBend.limits = joint;
        //}
        //HingeToBend.limits = joint;
    }
    
}
