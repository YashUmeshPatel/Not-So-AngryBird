//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/Scripts/Input System/GameControls.inputactions
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

public partial class @GameControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""Throwable"",
            ""id"": ""f51c7c52-eb00-46b0-ab9c-63ad810670cb"",
            ""actions"": [
                {
                    ""name"": ""Pull"",
                    ""type"": ""Value"",
                    ""id"": ""cb28a284-f3ee-492a-bd08-2c9baed795ae"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""728aef69-56ad-42a1-bc78-66bb2470e3db"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pull"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""7ff5fc5c-424b-4098-9d49-3a1747d5b80a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""321a18ee-5714-4a8e-9262-bf0188f3aafd"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Throwable
        m_Throwable = asset.FindActionMap("Throwable", throwIfNotFound: true);
        m_Throwable_Pull = m_Throwable.FindAction("Pull", throwIfNotFound: true);
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

    // Throwable
    private readonly InputActionMap m_Throwable;
    private List<IThrowableActions> m_ThrowableActionsCallbackInterfaces = new List<IThrowableActions>();
    private readonly InputAction m_Throwable_Pull;
    public struct ThrowableActions
    {
        private @GameControls m_Wrapper;
        public ThrowableActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pull => m_Wrapper.m_Throwable_Pull;
        public InputActionMap Get() { return m_Wrapper.m_Throwable; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ThrowableActions set) { return set.Get(); }
        public void AddCallbacks(IThrowableActions instance)
        {
            if (instance == null || m_Wrapper.m_ThrowableActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ThrowableActionsCallbackInterfaces.Add(instance);
            @Pull.started += instance.OnPull;
            @Pull.performed += instance.OnPull;
            @Pull.canceled += instance.OnPull;
        }

        private void UnregisterCallbacks(IThrowableActions instance)
        {
            @Pull.started -= instance.OnPull;
            @Pull.performed -= instance.OnPull;
            @Pull.canceled -= instance.OnPull;
        }

        public void RemoveCallbacks(IThrowableActions instance)
        {
            if (m_Wrapper.m_ThrowableActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IThrowableActions instance)
        {
            foreach (var item in m_Wrapper.m_ThrowableActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ThrowableActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ThrowableActions @Throwable => new ThrowableActions(this);
    public interface IThrowableActions
    {
        void OnPull(InputAction.CallbackContext context);
    }
}