using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Animation_Controller : MonoBehaviour
{
    protected Animator animator;
    protected string currentAnimation;

    public virtual void Awake() => animator = GetComponent<Animator>();

    public void ChangeAnimationState(string newAnimation)
    {
        if (currentAnimation == newAnimation) return;

        animator.Play(newAnimation);
        currentAnimation = newAnimation;
    }

}

public class PlayAnimations : Animation_Controller
{
    public Vector3 speed;
    CharacterController characterController;
    public string idleAnimation = "idle";
    public string runningAnimation = "running";
    float zvelocity = 0;
    float yvelocity = 0;

    public void GoToIdle() => ChangeAnimationState(idleAnimation);
    public void GoToRunning() => ChangeAnimationState(runningAnimation);

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
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.Play(runningAnimation);
        }*/

        if(Input.GetKeyDown(KeyCode.D))
        {
            zvelocity = 1;
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            zvelocity = -1;
        }
        else
        {
            zvelocity = 0;
        }

        speed = new Vector3(0, yvelocity, zvelocity);

        characterController.SimpleMove(speed);
    }


}

