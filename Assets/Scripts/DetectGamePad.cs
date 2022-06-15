using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XInput;
using UnityEngine.InputSystem.DualShock;

public class DetectGamePad : MonoBehaviour
{
    public bool DualShockController = false;
    public int Controllers;

    void Awake()
    {
        if(Gamepad.current is DualShockGamepad) DualShockController = true;
        Controllers = Gamepad.all.Count;
    }

}
