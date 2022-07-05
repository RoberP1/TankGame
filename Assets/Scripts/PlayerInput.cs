using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    private float UpDown, RightLeft, AimUpDown, AimRightLeft;
    [SerializeField]private Camera mainCamera;

    public UnityEvent OnShoot = new UnityEvent();
    public UnityEvent<Vector2> OnMoveBody = new UnityEvent<Vector2>();
    public UnityEvent<Vector2> OnMoveTurret = new UnityEvent<Vector2>();

    [SerializeField] string playerNumer;
    //private bool DualShockController;
    public InputSystemPlayer input;


    private void OnEnable()
    {


    }
    private void OnDisable()
    {
        input.Disable();

    }
    private void Awake()
    {
        input = new InputSystemPlayer();
        input.Enable();
        if (mainCamera == null)
            mainCamera = Camera.main;

        input.Player.Shoot.performed += ctx => { OnShoot?.Invoke(); };
    }
    private void Start()
    {
        //DualShockController = FindObjectOfType<DetectGamePad>().DualShockController;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        
        
        GetShootingInput();
        */
        GetTurretMovement();
        GetBodyMovement();
    }

    private void GetShootingInput()
    {
        /*
        if (DualShockController && Input.GetButtonDown("Fire1Joystick" + playerNumer) )
        {
            OnShoot?.Invoke();
        }
        else if(Input.GetButtonDown("XFire1Joystick" + playerNumer))
        {
            OnShoot?.Invoke();
        }*/
        
    }

    private void GetTurretMovement()
    {
        AimUpDown = input.Player.AImUpDown.ReadValue<float>();
        AimRightLeft = input.Player.AimRightLeft.ReadValue<float>();
        Vector2 AimVector = new Vector2(-AimRightLeft, AimUpDown);
        OnMoveTurret?.Invoke(AimVector);
    }

    private Vector2 GetMousePositon()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mainCamera.nearClipPlane;
        Vector2 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        return mouseWorldPosition;
    }
    private Vector2 GetJoystickPositon()
    {
        
        if (true )
        {
            Vector2 JoyDirection = new Vector2(Input.GetAxis("RightJoyY" + playerNumer), Input.GetAxis("RightJoyX" + playerNumer));
            return JoyDirection;
        }
        else
        {
            Vector2 JoyDirection = new Vector2(Input.GetAxis("XRightJoyY" + playerNumer), Input.GetAxis("XRightJoyX" + playerNumer));
            return JoyDirection;
        }
        
    }

    private void GetBodyMovement()
    {
        UpDown = input.Player.MoveUpDown.ReadValue<float>();
        RightLeft = input.Player.MoveRightLeft.ReadValue<float>();
        Vector2 movementVector =new Vector2(RightLeft, UpDown); ;
        //movementVector = MoveInput.ReadValue<Vector2>();
        /*
        if (DualShockController)
        {
            movementVector = new Vector2(Input.GetAxisRaw("JoyHorizontal" + playerNumer), Input.GetAxisRaw("JVertical+" + playerNumer) + Input.GetAxisRaw("JVertical-" + playerNumer));
        }
        else
        {
            movementVector = new Vector2(Input.GetAxisRaw("XJoyHorizontal" + playerNumer), Input.GetAxisRaw("JVertical" + playerNumer) );
        }
        */
        OnMoveBody?.Invoke(movementVector.normalized);
        
    }
}
