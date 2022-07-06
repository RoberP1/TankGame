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

    public static event Action<Transform> OnDie;
    bool alive;

    private void Awake()
    {
        alive = true;
        if (mainCamera == null)
            mainCamera = Camera.main;

        //input.Player.Shoot.performed += ctx => { OnShoot?.Invoke(); };

    }
    private void Start()
    {
        //DualShockController = FindObjectOfType<DetectGamePad>().DualShockController;
    }

    // Update is called once per frame
    void Update()
    {
        if (!alive) return;
        GetTurretMovement();
        
        GetBodyMovement();

    }



    public void GetShootingInput()
    {
        OnShoot?.Invoke();
    }

    private void GetTurretMovement()
    {
        Vector2 AimVector = new Vector2(-AimRightLeft, AimUpDown);
        if(AimVector.sqrMagnitude >= 0.1f)OnMoveTurret?.Invoke(AimVector);
    }
    public void SetAimUpDown(InputAction.CallbackContext ctx)
    {
        AimUpDown = ctx.ReadValue<float>();
    }
    public void SetMoveUpDown(InputAction.CallbackContext ctx)
    {
        UpDown = ctx.ReadValue<float>();
    }
    public void SetAimRightLeft(InputAction.CallbackContext ctx)
    {
        AimRightLeft = ctx.ReadValue<float>();
    }
    public void SetMoveRightLeft(InputAction.CallbackContext ctx)
    {
        RightLeft = ctx.ReadValue<float>();
    }

    public void die()
    {
        alive = false;
        OnDie?.Invoke(transform.GetChild(0));
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
        Vector2 movementVector =new Vector2(RightLeft, UpDown); ;

        OnMoveBody?.Invoke(movementVector.normalized);
        
    }
    public void Pause()
    {
        FindObjectOfType<LevelManager>().Pause();

    }
    public void ChangeOp(InputAction.CallbackContext ctx)
    {
        FindObjectOfType<MenuController>()?.ChangeOp(ctx);
    }
    public void Sumit()
    {
        FindObjectOfType<MenuController>()?.Sumit();
    }

}
