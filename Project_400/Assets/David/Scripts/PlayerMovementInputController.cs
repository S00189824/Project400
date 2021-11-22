using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;


public class PlayerMovementInputController : MonoBehaviour
{
    Animator animator;

    int isRunningHash;
    int isWalkingHash;

    PlayerInput input;
    CharacterController characterController;

    public float WalkingSpeed;
    public float RunningSpeed;
    public float rotationSpeed;
    Vector3 directionToMoveThisFrame;
    Vector3 velocity;
    Vector3 lastVelocity;
    Vector2 currentMovement;
    bool movementPressed;
    bool runPressed;

    CinemachineFreeLook cinemachine;
    Camera camera;

    private void Awake()
    {

        input = new PlayerInput();
        //input.CharacterControls.CameraMovement.performed += ctx =>
        //{
        //    cameraMovement = ctx.ReadValue<Vector2>();

        //    print(cameraMovement);
        //};

        input.CharacterControls.Movement.performed += OnMovementEvent;
        input.CharacterControls.Run.performed += ctx => runPressed = ctx.ReadValueAsButton();

        input.CharacterControls.KeyboardMovement.performed += KeyboardMovement_performed;
    }

    void OnMovementEvent(InputAction.CallbackContext ctx)
    {
        currentMovement = ctx.action.ReadValue<Vector2>();

        //Handles Movement Animations
        movementPressed = currentMovement.x != 0 || currentMovement.y != 0;
    }

    private float ReadAxis(string axisName)
    {
        print(axisName);
        return 0;
    }

    public void Start()
    {
        camera = Camera.main;
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();

        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    public void Update()
    {
        HandleMovement();
        handleRoation();


    }

    void handleRoation()
    {
        Vector3 currentPosiion = transform.position;

        Vector3 newPosition = new Vector3(currentMovement.x, 0, currentMovement.y);

        Vector3 positionToLookAt = currentPosiion + newPosition;

        transform.LookAt(positionToLookAt);
    }

    void HandleMovement()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);

        //if(currentMovement != Vector2.zero)
        //{
        //    float targetAngle = Mathf.Atan2(directionToMoveThisFrame.x, directionToMoveThisFrame.y) * (runPressed ? RunningSpeed : WalkingSpeed) * Time.deltaTime;
        //    Quaternion rotation = Quaternion.Euler(0f, targetAngle, 0f);
        //    transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
        //    //currentMovement = directionToMoveThisFrame;

        //    characterController.Move(directionToMoveThisFrame);
        //}

        directionToMoveThisFrame = camera.transform.TransformDirection(currentMovement);
        directionToMoveThisFrame = new Vector3(currentMovement.x, 0, currentMovement.y) * (runPressed ? RunningSpeed : WalkingSpeed) * Time.deltaTime;
        characterController.Move(directionToMoveThisFrame);



        if (movementPressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (!movementPressed && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if (movementPressed && runPressed && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }

        if ((!movementPressed || !runPressed) && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }
    }

    void OnEnable()
    {
        input.CharacterControls.Enable();
    }

    void OnDisable()
    {
        input.CharacterControls.Disable();
    }


    private void KeyboardMovement_performed(InputAction.CallbackContext obj)
    {
        Debug.Log("Do Walk");


    }

    private void OnDestroy()
    {
        input.CharacterControls.Movement.performed -= OnMovementEvent;
    }
}
