//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Sripts/Control/InGameInputAction.inputactions
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

public partial class @InGameInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InGameInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InGameInputAction"",
    ""maps"": [
        {
            ""name"": ""PlayerImputs"",
            ""id"": ""18ba859c-689f-4ee4-8e1a-36a9a9832ed8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""864ba70d-6e6b-4027-bd2e-1d77eaf9bf50"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""544274e8-c1eb-49e8-afbc-f6135abda5bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""e8014b46-115d-4f32-ba9e-65a9a1a1e437"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""0caa082f-e644-468d-8841-c3019f00d353"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""3281baba-2188-4043-a330-7371f67bc5e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""a7aed943-295b-46b4-9dad-dc3e6a0604d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5a9ccc5a-9533-4224-ae38-9afecdfbd6b1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ea6ba5f-10c0-4b00-a726-fd67561ac9ee"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d571ac8-1eca-442b-8556-db2ce04ed44b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7087de13-ca2a-48ab-8a46-9abc84dbb04a"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00a787d7-3907-4a1a-9493-7d60209578e4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bed21671-45df-459e-b0a9-ad8df7b60d88"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""MainMovement"",
                    ""id"": ""6ddf9fe4-9a57-4d16-807c-181df0700b08"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""146773ec-5c6b-4f84-bf49-ffb5499b9116"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f4c80fa2-fe38-43d1-a0b0-240be22ed024"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5c435b29-2085-43f0-9d20-1fe99a7d8501"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6da25acd-bd69-49e2-9132-37d0ec60431b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AlternativeMovement"",
                    ""id"": ""f112c07c-f889-4439-94b4-d1c81774305b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0a2c83f8-bcd3-42ec-b833-ed187db9057c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9d6c96a3-64d3-4dc2-aebc-be8a91f27cd5"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cad422f1-469b-4a40-8162-4de1939b9e99"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2713bdcd-92dd-426e-9ce5-1696c83f017f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""48d28f65-055b-4494-8bae-29bdda8af3dc"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""New action map"",
            ""id"": ""07fc4fee-1723-4970-85c7-7d1966fd2e72"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""79100325-0e3c-4ee1-a328-7e8b88b323c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b0f3976a-7298-42ed-a7fb-2d9f12c1f7b9"",
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
        // PlayerImputs
        m_PlayerImputs = asset.FindActionMap("PlayerImputs", throwIfNotFound: true);
        m_PlayerImputs_Move = m_PlayerImputs.FindAction("Move", throwIfNotFound: true);
        m_PlayerImputs_Jump = m_PlayerImputs.FindAction("Jump", throwIfNotFound: true);
        m_PlayerImputs_Down = m_PlayerImputs.FindAction("Down", throwIfNotFound: true);
        m_PlayerImputs_Esc = m_PlayerImputs.FindAction("Esc", throwIfNotFound: true);
        m_PlayerImputs_Dash = m_PlayerImputs.FindAction("Dash", throwIfNotFound: true);
        m_PlayerImputs_Interaction = m_PlayerImputs.FindAction("Interaction", throwIfNotFound: true);
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_Newaction = m_Newactionmap.FindAction("New action", throwIfNotFound: true);
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

    // PlayerImputs
    private readonly InputActionMap m_PlayerImputs;
    private List<IPlayerImputsActions> m_PlayerImputsActionsCallbackInterfaces = new List<IPlayerImputsActions>();
    private readonly InputAction m_PlayerImputs_Move;
    private readonly InputAction m_PlayerImputs_Jump;
    private readonly InputAction m_PlayerImputs_Down;
    private readonly InputAction m_PlayerImputs_Esc;
    private readonly InputAction m_PlayerImputs_Dash;
    private readonly InputAction m_PlayerImputs_Interaction;
    public struct PlayerImputsActions
    {
        private @InGameInputAction m_Wrapper;
        public PlayerImputsActions(@InGameInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerImputs_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerImputs_Jump;
        public InputAction @Down => m_Wrapper.m_PlayerImputs_Down;
        public InputAction @Esc => m_Wrapper.m_PlayerImputs_Esc;
        public InputAction @Dash => m_Wrapper.m_PlayerImputs_Dash;
        public InputAction @Interaction => m_Wrapper.m_PlayerImputs_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_PlayerImputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerImputsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerImputsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerImputsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerImputsActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Down.started += instance.OnDown;
            @Down.performed += instance.OnDown;
            @Down.canceled += instance.OnDown;
            @Esc.started += instance.OnEsc;
            @Esc.performed += instance.OnEsc;
            @Esc.canceled += instance.OnEsc;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
        }

        private void UnregisterCallbacks(IPlayerImputsActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Down.started -= instance.OnDown;
            @Down.performed -= instance.OnDown;
            @Down.canceled -= instance.OnDown;
            @Esc.started -= instance.OnEsc;
            @Esc.performed -= instance.OnEsc;
            @Esc.canceled -= instance.OnEsc;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
        }

        public void RemoveCallbacks(IPlayerImputsActions instance)
        {
            if (m_Wrapper.m_PlayerImputsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerImputsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerImputsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerImputsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerImputsActions @PlayerImputs => new PlayerImputsActions(this);

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private List<INewactionmapActions> m_NewactionmapActionsCallbackInterfaces = new List<INewactionmapActions>();
    private readonly InputAction m_Newactionmap_Newaction;
    public struct NewactionmapActions
    {
        private @InGameInputAction m_Wrapper;
        public NewactionmapActions(@InGameInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Newactionmap_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void AddCallbacks(INewactionmapActions instance)
        {
            if (instance == null || m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(INewactionmapActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(INewactionmapActions instance)
        {
            foreach (var item in m_Wrapper.m_NewactionmapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);
    public interface IPlayerImputsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
    }
    public interface INewactionmapActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}