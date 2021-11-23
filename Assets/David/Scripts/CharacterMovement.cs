using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Vector3 speed;
    CharacterController characterController;
    float zvelocity = 0;
    float yvelocity = 0;

    public void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Update()
    {
        /*horizontal = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.D))
        {
            animator.Play(runningAnimation);
            characterController.SimpleMove(speed);
        }*/
        if (Input.GetKey(KeyCode.D))
        {
            zvelocity = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            zvelocity = -1;
        }
        else
        {
            zvelocity = 0;
        }

        /*if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            zvelocity = 0;
        }*/
        
        speed = new Vector3(0, yvelocity, zvelocity);
        Debug.Log(zvelocity.ToString());
        characterController.SimpleMove(new Vector3(0,0,zvelocity));
    }
}
