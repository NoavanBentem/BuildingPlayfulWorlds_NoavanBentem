using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour
{
    public float speed = 10.0F;

    // Use this for initialization
    void Start(){
        Cursor.lockState = CursorLockMode.Locked;   //Makes cursor invisible

    }

    // Update is called once per frame
    void Update(){
            float translation = Input.GetAxis("Vertical") * speed;
            float straffe = Input.GetAxis("Horizontal") * speed;
            translation *= Time.deltaTime;
            straffe *= Time.deltaTime;
            transform.Translate(straffe, 0, translation);

            if (Input.GetKeyDown("escape"))
                Cursor.lockState = CursorLockMode.None;                    //Makes cursor come back when escape is down to give your cursor back oooooh
    }
}