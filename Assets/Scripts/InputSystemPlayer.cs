//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Input.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputSystemPlayer : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystemPlayer()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f36b00ed-f8cb-455f-a322-075d126bf152"",
            ""actions"": [
                {
                    ""name"": ""MenuSumit"",
                    ""type"": ""Button"",
                    ""id"": ""044a8f4a-fc9d-4716-a471-1f6f064f8f56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveUpDown"",
                    ""type"": ""Button"",
                    ""id"": ""b7c8c71b-6b55-4d23-90a6-d23ee0b625a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveRightLeft"",
                    ""type"": ""Button"",
                    ""id"": ""79d99c62-1830-4f32-990e-fe912fa8404a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""bfd8987d-a596-459d-ab06-d150dace70f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""461dd972-6261-44f5-9b02-8ab0a0bb9d74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeOp"",
                    ""type"": ""Button"",
                    ""id"": ""688cdb7b-1669-46ab-a9e6-789a64b586e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AImUpDown"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c4aa83c6-1265-41cf-9de2-37c93a08e95a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AimRightLeft"",
                    ""type"": ""Button"",
                    ""id"": ""4a35c95e-ddf9-4e0f-ad37-70e2f8936dc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""UpDown"",
                    ""id"": ""c82e9a3e-a5ca-44ea-8b2b-ed47b3bdf8b5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b022794e-aac1-484f-b3fc-d037612b8a00"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""670a2f11-4c64-4f3f-9e08-85fb109bc454"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""UpDown"",
                    ""id"": ""2865da44-e306-49b5-bbf2-51a51612c584"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""391ec74b-87fd-455d-9a00-dc3795ac72a7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""da396d80-81dc-42bb-850d-3c18f93dc6c3"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2015961a-2cf6-40ef-ab8f-6b35366b1e3e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6114890-aa3b-4996-b08e-cd740bbb3eac"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""4c32e2d0-fb88-405e-8ae8-12905b6862c8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeOp"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""32d47e5c-4cf4-4cb3-a24e-0202f80ead04"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeOp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b6f6dc72-77f8-48c2-b4a1-bc1328553444"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeOp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""UpDown"",
                    ""id"": ""fd503234-56fe-437b-a450-55aa900f6bb3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AImUpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""4545d7b0-32de-4523-9bca-4f95782f9ec6"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AImUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""3f55bd51-c5eb-427a-a704-0e4c36c751a6"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AImUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RightLeft"",
                    ""id"": ""b1ccbc74-e40b-4e0e-aff8-18b5c128d30c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimRightLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ec270cc6-ad7f-4b13-8682-0188e70787e1"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimRightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2e78f7e2-dd14-41dd-9d3b-15ff193c54c7"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimRightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""67d14cdc-77fa-49f2-bd6e-c54199b82364"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuSumit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MenuSumit = m_Player.FindAction("MenuSumit", throwIfNotFound: true);
        m_Player_MoveUpDown = m_Player.FindAction("MoveUpDown", throwIfNotFound: true);
        m_Player_MoveRightLeft = m_Player.FindAction("MoveRightLeft", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        m_Player_ChangeOp = m_Player.FindAction("ChangeOp", throwIfNotFound: true);
        m_Player_AImUpDown = m_Player.FindAction("AImUpDown", throwIfNotFound: true);
        m_Player_AimRightLeft = m_Player.FindAction("AimRightLeft", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MenuSumit;
    private readonly InputAction m_Player_MoveUpDown;
    private readonly InputAction m_Player_MoveRightLeft;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_Pause;
    private readonly InputAction m_Player_ChangeOp;
    private readonly InputAction m_Player_AImUpDown;
    private readonly InputAction m_Player_AimRightLeft;
    public struct PlayerActions
    {
        private @InputSystemPlayer m_Wrapper;
        public PlayerActions(@InputSystemPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuSumit => m_Wrapper.m_Player_MenuSumit;
        public InputAction @MoveUpDown => m_Wrapper.m_Player_MoveUpDown;
        public InputAction @MoveRightLeft => m_Wrapper.m_Player_MoveRightLeft;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputAction @ChangeOp => m_Wrapper.m_Player_ChangeOp;
        public InputAction @AImUpDown => m_Wrapper.m_Player_AImUpDown;
        public InputAction @AimRightLeft => m_Wrapper.m_Player_AimRightLeft;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MenuSumit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuSumit;
                @MenuSumit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuSumit;
                @MenuSumit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuSumit;
                @MoveUpDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveUpDown;
                @MoveUpDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveUpDown;
                @MoveUpDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveUpDown;
                @MoveRightLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRightLeft;
                @MoveRightLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRightLeft;
                @MoveRightLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRightLeft;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @ChangeOp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeOp;
                @ChangeOp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeOp;
                @ChangeOp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeOp;
                @AImUpDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAImUpDown;
                @AImUpDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAImUpDown;
                @AImUpDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAImUpDown;
                @AimRightLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAimRightLeft;
                @AimRightLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAimRightLeft;
                @AimRightLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAimRightLeft;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MenuSumit.started += instance.OnMenuSumit;
                @MenuSumit.performed += instance.OnMenuSumit;
                @MenuSumit.canceled += instance.OnMenuSumit;
                @MoveUpDown.started += instance.OnMoveUpDown;
                @MoveUpDown.performed += instance.OnMoveUpDown;
                @MoveUpDown.canceled += instance.OnMoveUpDown;
                @MoveRightLeft.started += instance.OnMoveRightLeft;
                @MoveRightLeft.performed += instance.OnMoveRightLeft;
                @MoveRightLeft.canceled += instance.OnMoveRightLeft;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @ChangeOp.started += instance.OnChangeOp;
                @ChangeOp.performed += instance.OnChangeOp;
                @ChangeOp.canceled += instance.OnChangeOp;
                @AImUpDown.started += instance.OnAImUpDown;
                @AImUpDown.performed += instance.OnAImUpDown;
                @AImUpDown.canceled += instance.OnAImUpDown;
                @AimRightLeft.started += instance.OnAimRightLeft;
                @AimRightLeft.performed += instance.OnAimRightLeft;
                @AimRightLeft.canceled += instance.OnAimRightLeft;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMenuSumit(InputAction.CallbackContext context);
        void OnMoveUpDown(InputAction.CallbackContext context);
        void OnMoveRightLeft(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnChangeOp(InputAction.CallbackContext context);
        void OnAImUpDown(InputAction.CallbackContext context);
        void OnAimRightLeft(InputAction.CallbackContext context);
    }
}
