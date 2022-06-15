using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    public UnityEvent OnShoot = new UnityEvent();
    public UnityEvent<Vector2> OnMoveBody = new UnityEvent<Vector2>();
    public UnityEvent<Vector2> OnMoveTurret = new UnityEvent<Vector2>();

    [SerializeField] string playerNumer;
    private bool DualShockController;
    private void Awake()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;
        
    }
    private void Start()
    {
        DualShockController = FindObjectOfType<DetectGamePad>().DualShockController;
    }

    // Update is called once per frame
    void Update()
    {
        GetBodyMovement();
        GetTurretMovement();
        GetShootingInput();
    }

    private void GetShootingInput()
    {
        if (DualShockController && Input.GetButtonDown("Fire1Joystick" + playerNumer) )
        {
            OnShoot?.Invoke();
        }
        else if(Input.GetButtonDown("XFire1Joystick" + playerNumer))
        {
            OnShoot?.Invoke();
        }
    }

    private void GetTurretMovement()
    {
        OnMoveTurret?.Invoke(GetJoystickPositon());
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
        if (DualShockController )
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
        Vector2 movementVector;
        if (DualShockController)
        {
            movementVector = new Vector2(Input.GetAxisRaw("JoyHorizontal" + playerNumer), Input.GetAxisRaw("JVertical+" + playerNumer) + Input.GetAxisRaw("JVertical-" + playerNumer));
        }
        else
        {
            movementVector = new Vector2(Input.GetAxisRaw("XJoyHorizontal" + playerNumer), Input.GetAxisRaw("JVertical" + playerNumer) );
        }

        OnMoveBody?.Invoke(movementVector.normalized);
    }
}
