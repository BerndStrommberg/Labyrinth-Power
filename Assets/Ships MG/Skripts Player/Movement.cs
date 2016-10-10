using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
        // CharacterController localCharacterController;
    public float speed;
    public float turnSpeed;
    public bool up;

    void Start ()
    {
        speed = 1f;
        turnSpeed = 100f;
        up = false;
    //localCharacterController = GetComponent<CharacterController>();
}

    void Update ()
    {


        if (Input.GetKey(KeyCode.UpArrow))
        {
            up = true;
        } else
        {
            up = false;
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(new Vector3(0, (speed), 0) * Time.deltaTime);
            
        }


        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(-(new Vector3(0, (speed), 0)) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate((new Vector3(0, 0, (turnSpeed))) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate((new Vector3(0, 0, (-turnSpeed))) * Time.deltaTime);
        }
        
    }
    
}