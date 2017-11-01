using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    CameraOrbit cam;
    public RaycastHit currentHit;
    // Use this for initialization
    void Start() {
        cam = GetComponent<CameraOrbit>();
    }

    // Update is called once per frame
    void Update() {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out currentHit, Mathf.Infinity, LayerMask.GetMask("Default")))
        {
            if (Input.GetMouseButtonDown(0))
            {
                IClickable clickedObj = currentHit.collider.GetComponent<IClickable>();
                if (clickedObj != null) clickedObj.OnClicked(0);
            }
            float scrollWheelInput = Input.GetAxis("Mouse ScrollWheel");
            if (Mathf.Abs(scrollWheelInput) > 0f)
            {
                IScrollable scrolledObj = currentHit.collider.GetComponent<IScrollable>();
                if (scrolledObj != null) scrolledObj.OnScrolled(scrollWheelInput);
            }
        }
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