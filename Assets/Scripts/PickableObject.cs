using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{

    public Transform TransformCamera;
    public LayerMask RayMask;
    private RaycastHit hit;
    public Transform currentTransform;
    private float length;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Physics.Raycast(TransformCamera.position, TransformCamera.forward, out hit, 3f, RayMask))
            {
                if (hit.transform.tag == "PickableObject")
                {
                    SetNewTransform(hit.transform);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            RemoveTransform();
        }
        if (currentTransform)
            MoveTransformAround();


       
            

    }

    public void SetNewTransform(Transform newTransform)
    {
        if (currentTransform)
            return;

        currentTransform = newTransform;

        length = Vector3.Distance(TransformCamera.position, newTransform.position);

        currentTransform.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void MoveTransformAround()
    {
        currentTransform.position = TransformCamera.position + TransformCamera.forward * length;
    }

    public void RemoveTransform()
    {
        if (!currentTransform)
            return;

        currentTransform.GetComponent<Rigidbody>().isKinematic = false;
        currentTransform = null;
    }
}
