using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCam : MonoBehaviour {
    Vector2 mouseLook;
    Vector2 smooth;
    public float sensitivity = 5.0F;
    public float smoothing = 2.0F;

    GameObject character;

	// Use this for initialization
	void Start () {
        character = this.transform.parent.gameObject;

	}
	
	// Update is called once per frame
	void Update () {
        var mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smooth.x = Mathf.Lerp(smooth.x, mouseDelta.x, 1F / smoothing);
        smooth.y = Mathf.Lerp(smooth.y, mouseDelta.y, 1F / smoothing);
        mouseLook += smooth;
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y,    Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);


	}
}
