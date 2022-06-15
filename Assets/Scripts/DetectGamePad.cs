using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XInput;
using UnityEngine.InputSystem.DualShock;

public class DetectGamePad : MonoBehaviour
{
    public bool DualShockController = false;
    void Awake()
    {
        if(Gamepad.current is DualShockGamepad) DualShockController = true;
    }

}
