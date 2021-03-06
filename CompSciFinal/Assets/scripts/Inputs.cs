//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/scripts/Inputs.inputactions
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

public partial class @Inputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""buttonThings"",
            ""id"": ""10e327a0-097b-42e1-ad53-2aef5861c66b"",
            ""actions"": [
                {
                    ""name"": ""Key1"",
                    ""type"": ""Value"",
                    ""id"": ""dd2591c2-707c-4e4f-bb6b-bd6689d0befa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Key2"",
                    ""type"": ""Value"",
                    ""id"": ""ccc3b6f7-8f72-4e09-80b4-aea8337c8495"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Key3"",
                    ""type"": ""Value"",
                    ""id"": ""2b2b9b4e-28e1-48f7-acf4-bd0b7e8e5da3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Key4"",
                    ""type"": ""Value"",
                    ""id"": ""b0da44b1-d87a-4625-8df9-9a2beec9ec32"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bff4673a-451b-48c1-9b24-3da835cf5300"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""451854e2-d3f4-44b2-8ea8-0864a0e5b357"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bd65e55-e290-4651-853b-5a0abedf6279"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b054104a-a3d0-4874-89e1-a6f480c8fb29"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebd516b6-629a-44bc-b8c8-f68982b16fff"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ec75011-5c4a-48ce-863d-199c4e042a0b"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60655d5c-c533-4197-b6b5-e49482034675"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6051cbd-06bc-4eed-92ee-982e5341d2ed"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // buttonThings
        m_buttonThings = asset.FindActionMap("buttonThings", throwIfNotFound: true);
        m_buttonThings_Key1 = m_buttonThings.FindAction("Key1", throwIfNotFound: true);
        m_buttonThings_Key2 = m_buttonThings.FindAction("Key2", throwIfNotFound: true);
        m_buttonThings_Key3 = m_buttonThings.FindAction("Key3", throwIfNotFound: true);
        m_buttonThings_Key4 = m_buttonThings.FindAction("Key4", throwIfNotFound: true);
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

    // buttonThings
    private readonly InputActionMap m_buttonThings;
    private IButtonThingsActions m_ButtonThingsActionsCallbackInterface;
    private readonly InputAction m_buttonThings_Key1;
    private readonly InputAction m_buttonThings_Key2;
    private readonly InputAction m_buttonThings_Key3;
    private readonly InputAction m_buttonThings_Key4;
    public struct ButtonThingsActions
    {
        private @Inputs m_Wrapper;
        public ButtonThingsActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Key1 => m_Wrapper.m_buttonThings_Key1;
        public InputAction @Key2 => m_Wrapper.m_buttonThings_Key2;
        public InputAction @Key3 => m_Wrapper.m_buttonThings_Key3;
        public InputAction @Key4 => m_Wrapper.m_buttonThings_Key4;
        public InputActionMap Get() { return m_Wrapper.m_buttonThings; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ButtonThingsActions set) { return set.Get(); }
        public void SetCallbacks(IButtonThingsActions instance)
        {
            if (m_Wrapper.m_ButtonThingsActionsCallbackInterface != null)
            {
                @Key1.started -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey1;
                @Key1.performed -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey1;
                @Key1.canceled -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey1;
                @Key2.started -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey2;
                @Key2.performed -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey2;
                @Key2.canceled -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey2;
                @Key3.started -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey3;
                @Key3.performed -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey3;
                @Key3.canceled -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey3;
                @Key4.started -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey4;
                @Key4.performed -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey4;
                @Key4.canceled -= m_Wrapper.m_ButtonThingsActionsCallbackInterface.OnKey4;
            }
            m_Wrapper.m_ButtonThingsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Key1.started += instance.OnKey1;
                @Key1.performed += instance.OnKey1;
                @Key1.canceled += instance.OnKey1;
                @Key2.started += instance.OnKey2;
                @Key2.performed += instance.OnKey2;
                @Key2.canceled += instance.OnKey2;
                @Key3.started += instance.OnKey3;
                @Key3.performed += instance.OnKey3;
                @Key3.canceled += instance.OnKey3;
                @Key4.started += instance.OnKey4;
                @Key4.performed += instance.OnKey4;
                @Key4.canceled += instance.OnKey4;
            }
        }
    }
    public ButtonThingsActions @buttonThings => new ButtonThingsActions(this);
    public interface IButtonThingsActions
    {
        void OnKey1(InputAction.CallbackContext context);
        void OnKey2(InputAction.CallbackContext context);
        void OnKey3(InputAction.CallbackContext context);
        void OnKey4(InputAction.CallbackContext context);
    }
}
