//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Yohann/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""ControllerInput"",
            ""id"": ""afb78783-4365-434c-b155-03b28179240a"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""6878be7b-d53e-43f0-b372-86983b014773"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""874c16e5-fd29-4a20-b39b-89cbe8643994"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SimpleAttack"",
                    ""type"": ""Button"",
                    ""id"": ""de4f8de9-8020-4f1f-a964-53461d418968"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SpecialAttack"",
                    ""type"": ""Button"",
                    ""id"": ""edefd138-2fff-4aac-8a26-32b581d8b096"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""55e2eeec-151f-49cd-9092-cb2a364fa5d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f0a34a91-0fcd-44e5-b505-11360d23b5bb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""443e638b-3b38-4f83-b730-7238d1102fb9"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b71b7be3-d580-44a2-b432-113002cf46ca"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a4cabcc0-b0a3-4e45-914a-3ff27c488c98"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""99ae89bc-09cd-4cf8-a865-dc6a27e57e3e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""60359e47-9e1d-40d2-b1d4-57c0f500226b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3dd2e267-1adf-4ad3-a5d4-90ab9fc9b075"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SimpleAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5a3dc13-e88f-43ba-a4e4-2be0a8c48352"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""697a9974-f142-4adb-9e5c-5f3d04eebeca"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Player1"",
            ""bindingGroup"": ""Player1"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""bindingGroup"": ""Player2"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Player3"",
            ""bindingGroup"": ""Player3"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Player4"",
            ""bindingGroup"": ""Player4"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ControllerInput
        m_ControllerInput = asset.FindActionMap("ControllerInput", throwIfNotFound: true);
        m_ControllerInput_Horizontal = m_ControllerInput.FindAction("Horizontal", throwIfNotFound: true);
        m_ControllerInput_Vertical = m_ControllerInput.FindAction("Vertical", throwIfNotFound: true);
        m_ControllerInput_SimpleAttack = m_ControllerInput.FindAction("SimpleAttack", throwIfNotFound: true);
        m_ControllerInput_SpecialAttack = m_ControllerInput.FindAction("SpecialAttack", throwIfNotFound: true);
        m_ControllerInput_Start = m_ControllerInput.FindAction("Start", throwIfNotFound: true);
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

    // ControllerInput
    private readonly InputActionMap m_ControllerInput;
    private IControllerInputActions m_ControllerInputActionsCallbackInterface;
    private readonly InputAction m_ControllerInput_Horizontal;
    private readonly InputAction m_ControllerInput_Vertical;
    private readonly InputAction m_ControllerInput_SimpleAttack;
    private readonly InputAction m_ControllerInput_SpecialAttack;
    private readonly InputAction m_ControllerInput_Start;
    public struct ControllerInputActions
    {
        private @PlayerInput m_Wrapper;
        public ControllerInputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_ControllerInput_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_ControllerInput_Vertical;
        public InputAction @SimpleAttack => m_Wrapper.m_ControllerInput_SimpleAttack;
        public InputAction @SpecialAttack => m_Wrapper.m_ControllerInput_SpecialAttack;
        public InputAction @Start => m_Wrapper.m_ControllerInput_Start;
        public InputActionMap Get() { return m_Wrapper.m_ControllerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllerInputActions set) { return set.Get(); }
        public void SetCallbacks(IControllerInputActions instance)
        {
            if (m_Wrapper.m_ControllerInputActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnVertical;
                @SimpleAttack.started -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnSimpleAttack;
                @SimpleAttack.performed -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnSimpleAttack;
                @SimpleAttack.canceled -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnSimpleAttack;
                @SpecialAttack.started -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.performed -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.canceled -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnSpecialAttack;
                @Start.started -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_ControllerInputActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_ControllerInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @SimpleAttack.started += instance.OnSimpleAttack;
                @SimpleAttack.performed += instance.OnSimpleAttack;
                @SimpleAttack.canceled += instance.OnSimpleAttack;
                @SpecialAttack.started += instance.OnSpecialAttack;
                @SpecialAttack.performed += instance.OnSpecialAttack;
                @SpecialAttack.canceled += instance.OnSpecialAttack;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public ControllerInputActions @ControllerInput => new ControllerInputActions(this);
    private int m_Player1SchemeIndex = -1;
    public InputControlScheme Player1Scheme
    {
        get
        {
            if (m_Player1SchemeIndex == -1) m_Player1SchemeIndex = asset.FindControlSchemeIndex("Player1");
            return asset.controlSchemes[m_Player1SchemeIndex];
        }
    }
    private int m_Player2SchemeIndex = -1;
    public InputControlScheme Player2Scheme
    {
        get
        {
            if (m_Player2SchemeIndex == -1) m_Player2SchemeIndex = asset.FindControlSchemeIndex("Player2");
            return asset.controlSchemes[m_Player2SchemeIndex];
        }
    }
    private int m_Player3SchemeIndex = -1;
    public InputControlScheme Player3Scheme
    {
        get
        {
            if (m_Player3SchemeIndex == -1) m_Player3SchemeIndex = asset.FindControlSchemeIndex("Player3");
            return asset.controlSchemes[m_Player3SchemeIndex];
        }
    }
    private int m_Player4SchemeIndex = -1;
    public InputControlScheme Player4Scheme
    {
        get
        {
            if (m_Player4SchemeIndex == -1) m_Player4SchemeIndex = asset.FindControlSchemeIndex("Player4");
            return asset.controlSchemes[m_Player4SchemeIndex];
        }
    }
    public interface IControllerInputActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnSimpleAttack(InputAction.CallbackContext context);
        void OnSpecialAttack(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}
