using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    CameraOrbit cam;

    // Use this for initialization
    void Start() {
        cam = GetComponent<CameraOrbit>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cam.MoveHorizontal(true);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            cam.MoveHorizontal(false);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            cam.MoveVertical(true);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            cam.MoveVertical(false);
        }

    }
}