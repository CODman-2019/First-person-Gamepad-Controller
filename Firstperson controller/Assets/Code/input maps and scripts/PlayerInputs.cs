// GENERATED AUTOMATICALLY FROM 'Assets/Code/input maps and scripts/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Gamepad controls"",
            ""id"": ""c0b50526-4e57-494d-86b6-7e3d7f6b004a"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""5fa89150-0448-4868-8be4-69718885292d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""a24889f4-24dc-4fdf-8d18-6065d5252b6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""88f94184-d5b1-4cce-b007-968dc4abaaf3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""95870b0d-aae9-4b60-92ac-5f5198c779a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e7e79184-c782-4063-bfe7-20a926bcc978"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c0ede70c-6eb1-46b8-8a17-341d021ea368"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint toggle"",
                    ""type"": ""Button"",
                    ""id"": ""3017dc84-8fce-4655-8964-12d346398302"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""28b85e1f-f26b-4a71-9200-e4cef66040c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim Down"",
                    ""type"": ""Button"",
                    ""id"": ""61d797b4-9562-485b-9038-e8beb026830e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""d5d810bc-77c8-4313-83f6-ea7b6378ea91"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""6525f52d-048c-4154-b9f7-6599c6288ef1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""93c13195-e874-49a2-8c34-cfb4529e0d52"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fd55c58-e765-4173-9150-93c0834c86a9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""160a1cea-deaf-475a-b8e6-a2e7f4db5e97"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf26e624-bc98-41b3-96cf-1b006e876827"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edd691dd-eb41-4d89-a8c4-c75e9c66a984"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff7c9c97-e4dc-4ba3-b94e-e9a3d48a3216"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d23f2fa-9b98-433c-b8f7-2e979795cce7"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint toggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17de8990-57aa-4df2-b5c7-c35f3ecb588d"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cfd2f60-c0cd-4fa7-aac2-f78bc801692b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Hold(pressPoint=0.25)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73c00c0a-5e4c-4a2d-a03d-88b5b3e5d2c5"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d7ca7e9-74b5-4d31-aac6-197e4a8c6626"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gamepad controls
        m_Gamepadcontrols = asset.FindActionMap("Gamepad controls", throwIfNotFound: true);
        m_Gamepadcontrols_Pause = m_Gamepadcontrols.FindAction("Pause", throwIfNotFound: true);
        m_Gamepadcontrols_Accept = m_Gamepadcontrols.FindAction("Accept", throwIfNotFound: true);
        m_Gamepadcontrols_Jump = m_Gamepadcontrols.FindAction("Jump", throwIfNotFound: true);
        m_Gamepadcontrols_Reload = m_Gamepadcontrols.FindAction("Reload", throwIfNotFound: true);
        m_Gamepadcontrols_Move = m_Gamepadcontrols.FindAction("Move", throwIfNotFound: true);
        m_Gamepadcontrols_Look = m_Gamepadcontrols.FindAction("Look", throwIfNotFound: true);
        m_Gamepadcontrols_Sprinttoggle = m_Gamepadcontrols.FindAction("Sprint toggle", throwIfNotFound: true);
        m_Gamepadcontrols_Melee = m_Gamepadcontrols.FindAction("Melee", throwIfNotFound: true);
        m_Gamepadcontrols_AimDown = m_Gamepadcontrols.FindAction("Aim Down", throwIfNotFound: true);
        m_Gamepadcontrols_Shoot = m_Gamepadcontrols.FindAction("Shoot", throwIfNotFound: true);
        m_Gamepadcontrols_Newaction = m_Gamepadcontrols.FindAction("New action", throwIfNotFound: true);
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

    // Gamepad controls
    private readonly InputActionMap m_Gamepadcontrols;
    private IGamepadcontrolsActions m_GamepadcontrolsActionsCallbackInterface;
    private readonly InputAction m_Gamepadcontrols_Pause;
    private readonly InputAction m_Gamepadcontrols_Accept;
    private readonly InputAction m_Gamepadcontrols_Jump;
    private readonly InputAction m_Gamepadcontrols_Reload;
    private readonly InputAction m_Gamepadcontrols_Move;
    private readonly InputAction m_Gamepadcontrols_Look;
    private readonly InputAction m_Gamepadcontrols_Sprinttoggle;
    private readonly InputAction m_Gamepadcontrols_Melee;
    private readonly InputAction m_Gamepadcontrols_AimDown;
    private readonly InputAction m_Gamepadcontrols_Shoot;
    private readonly InputAction m_Gamepadcontrols_Newaction;
    public struct GamepadcontrolsActions
    {
        private @PlayerInputs m_Wrapper;
        public GamepadcontrolsActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Gamepadcontrols_Pause;
        public InputAction @Accept => m_Wrapper.m_Gamepadcontrols_Accept;
        public InputAction @Jump => m_Wrapper.m_Gamepadcontrols_Jump;
        public InputAction @Reload => m_Wrapper.m_Gamepadcontrols_Reload;
        public InputAction @Move => m_Wrapper.m_Gamepadcontrols_Move;
        public InputAction @Look => m_Wrapper.m_Gamepadcontrols_Look;
        public InputAction @Sprinttoggle => m_Wrapper.m_Gamepadcontrols_Sprinttoggle;
        public InputAction @Melee => m_Wrapper.m_Gamepadcontrols_Melee;
        public InputAction @AimDown => m_Wrapper.m_Gamepadcontrols_AimDown;
        public InputAction @Shoot => m_Wrapper.m_Gamepadcontrols_Shoot;
        public InputAction @Newaction => m_Wrapper.m_Gamepadcontrols_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Gamepadcontrols; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadcontrolsActions set) { return set.Get(); }
        public void SetCallbacks(IGamepadcontrolsActions instance)
        {
            if (m_Wrapper.m_GamepadcontrolsActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnPause;
                @Accept.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnAccept;
                @Accept.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnAccept;
                @Accept.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnAccept;
                @Jump.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnJump;
                @Reload.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnReload;
                @Move.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnLook;
                @Sprinttoggle.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnSprinttoggle;
                @Sprinttoggle.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnSprinttoggle;
                @Sprinttoggle.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnSprinttoggle;
                @Melee.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnMelee;
                @AimDown.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnAimDown;
                @AimDown.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnAimDown;
                @AimDown.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnAimDown;
                @Shoot.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnShoot;
                @Newaction.started -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_GamepadcontrolsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_GamepadcontrolsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Accept.started += instance.OnAccept;
                @Accept.performed += instance.OnAccept;
                @Accept.canceled += instance.OnAccept;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Sprinttoggle.started += instance.OnSprinttoggle;
                @Sprinttoggle.performed += instance.OnSprinttoggle;
                @Sprinttoggle.canceled += instance.OnSprinttoggle;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
                @AimDown.started += instance.OnAimDown;
                @AimDown.performed += instance.OnAimDown;
                @AimDown.canceled += instance.OnAimDown;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public GamepadcontrolsActions @Gamepadcontrols => new GamepadcontrolsActions(this);
    public interface IGamepadcontrolsActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnAccept(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnSprinttoggle(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
        void OnAimDown(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
}
