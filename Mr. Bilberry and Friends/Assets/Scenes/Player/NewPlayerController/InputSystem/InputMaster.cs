// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/Player/NewPlayerController/InputSystem/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b071d852-de79-4c89-9ebf-9938d5b17d74"",
            ""actions"": [
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""211f2a62-77b2-4fc5-9b2d-e608b1e5e18a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""db3ff76c-39c5-43a9-96ea-ef19abc37f22"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""18ebcd0d-b34a-4add-9374-5c926053cd46"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""e1a9ef98-87aa-488a-b7b7-196b54e57842"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sneak"",
                    ""type"": ""Value"",
                    ""id"": ""ddb42c1a-2051-4d96-8c5e-e28f53585a47"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""41673f2a-a3f6-456b-a630-fd7816cc42a5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Taunt"",
                    ""type"": ""Button"",
                    ""id"": ""824b4f64-a704-45ca-9174-2d82b43de47c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveByMouse"",
                    ""type"": ""Value"",
                    ""id"": ""f65858da-ae7c-4a9b-9ecc-f45423b42c93"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveByStick"",
                    ""type"": ""Value"",
                    ""id"": ""460e80c8-c5e0-46d3-9813-e052a7fbffe4"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": ""ScaleVector2(x=7,y=7)"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4dc609f-845b-4f30-9dbe-eb91a79b5508"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21296df4-1857-40f6-a27f-56ab2986a2d1"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXbox"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4998fb79-eaa8-490a-9c56-b4e8aed572fd"",
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
                    ""id"": ""962cc570-fda5-4b6b-9c4b-b200a8cfcd8e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9bdd9b6e-270f-4c4b-b24f-82db4f10c416"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""87c9a9c4-c95e-4f19-94cc-e1958f3c251a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f2448629-bda2-4f57-8cd9-a3500b008d28"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b8d7c150-eea2-43fb-a6f2-53e010c571e0"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXbox"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb102b2b-c9ab-4da4-8c6e-79f005d64db0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f489b0a-ee76-4482-b4b0-bb69eb348209"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXbox"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""668e88b6-9eb1-4033-ba07-645d53c88255"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""aced5a0b-e5e7-497e-a9ed-49162eb3a802"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""96ebbe19-4991-4de5-a72b-04fb2aea00be"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""794f4745-6744-421d-a6de-4fc5de3b2e4d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXbox"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85c03d0a-9f6d-4a0b-b8a3-b5674da9eb71"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sneak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28259717-3e52-4528-805f-08a12efa48cc"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXbox"",
                    ""action"": ""Sneak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66f13348-ef0a-42b6-aee2-6738968d6260"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc;Keyboard"",
                    ""action"": ""Taunt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9e36c96-c94b-4da1-bea4-e6c2cafe921b"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXbox"",
                    ""action"": ""Taunt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3996bd0b-6462-4465-b435-2193fe05e432"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveByMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb9b9261-1ee1-4b38-a983-24b7d19a827d"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXbox"",
                    ""action"": ""MoveByStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""6356040c-4e75-45b5-abf5-0473557166c3"",
            ""actions"": [
                {
                    ""name"": ""MoveByMouse"",
                    ""type"": ""Value"",
                    ""id"": ""741d398e-1b4b-4d9a-85fa-e562c8f78d2b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwapCamera"",
                    ""type"": ""Button"",
                    ""id"": ""6a8c04ed-859d-4dd1-89cb-f73af6d3992b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveByStick"",
                    ""type"": ""Value"",
                    ""id"": ""15264e18-b4e0-45e4-9689-3aaf34a861f5"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": ""ScaleVector2(x=7,y=7)"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""950af3bb-c1c4-4ea6-ae3e-4c1b532f9e15"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveByMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ecec5ec6-e0de-4724-9d1d-eb37f9023d6b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SwapCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c341587-8110-4b21-9cd0-8643a5a92349"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXbox"",
                    ""action"": ""SwapCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52204dfb-fc84-4073-b02d-ce9f59fe1079"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXbox"",
                    ""action"": ""MoveByStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Pc"",
            ""bindingGroup"": ""Pc"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""ControllerXbox"",
            ""bindingGroup"": ""ControllerXbox"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_Sneak = m_Player.FindAction("Sneak", throwIfNotFound: true);
        m_Player_Reload = m_Player.FindAction("Reload", throwIfNotFound: true);
        m_Player_Taunt = m_Player.FindAction("Taunt", throwIfNotFound: true);
        m_Player_MoveByMouse = m_Player.FindAction("MoveByMouse", throwIfNotFound: true);
        m_Player_MoveByStick = m_Player.FindAction("MoveByStick", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_MoveByMouse = m_Camera.FindAction("MoveByMouse", throwIfNotFound: true);
        m_Camera_SwapCamera = m_Camera.FindAction("SwapCamera", throwIfNotFound: true);
        m_Camera_MoveByStick = m_Camera.FindAction("MoveByStick", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_Sneak;
    private readonly InputAction m_Player_Reload;
    private readonly InputAction m_Player_Taunt;
    private readonly InputAction m_Player_MoveByMouse;
    private readonly InputAction m_Player_MoveByStick;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @Sneak => m_Wrapper.m_Player_Sneak;
        public InputAction @Reload => m_Wrapper.m_Player_Reload;
        public InputAction @Taunt => m_Wrapper.m_Player_Taunt;
        public InputAction @MoveByMouse => m_Wrapper.m_Player_MoveByMouse;
        public InputAction @MoveByStick => m_Wrapper.m_Player_MoveByStick;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Sneak.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSneak;
                @Sneak.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSneak;
                @Sneak.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSneak;
                @Reload.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Taunt.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTaunt;
                @Taunt.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTaunt;
                @Taunt.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTaunt;
                @MoveByMouse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveByMouse;
                @MoveByMouse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveByMouse;
                @MoveByMouse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveByMouse;
                @MoveByStick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveByStick;
                @MoveByStick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveByStick;
                @MoveByStick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveByStick;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Sneak.started += instance.OnSneak;
                @Sneak.performed += instance.OnSneak;
                @Sneak.canceled += instance.OnSneak;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Taunt.started += instance.OnTaunt;
                @Taunt.performed += instance.OnTaunt;
                @Taunt.canceled += instance.OnTaunt;
                @MoveByMouse.started += instance.OnMoveByMouse;
                @MoveByMouse.performed += instance.OnMoveByMouse;
                @MoveByMouse.canceled += instance.OnMoveByMouse;
                @MoveByStick.started += instance.OnMoveByStick;
                @MoveByStick.performed += instance.OnMoveByStick;
                @MoveByStick.canceled += instance.OnMoveByStick;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_MoveByMouse;
    private readonly InputAction m_Camera_SwapCamera;
    private readonly InputAction m_Camera_MoveByStick;
    public struct CameraActions
    {
        private @InputMaster m_Wrapper;
        public CameraActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveByMouse => m_Wrapper.m_Camera_MoveByMouse;
        public InputAction @SwapCamera => m_Wrapper.m_Camera_SwapCamera;
        public InputAction @MoveByStick => m_Wrapper.m_Camera_MoveByStick;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @MoveByMouse.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMoveByMouse;
                @MoveByMouse.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMoveByMouse;
                @MoveByMouse.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMoveByMouse;
                @SwapCamera.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnSwapCamera;
                @SwapCamera.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnSwapCamera;
                @SwapCamera.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnSwapCamera;
                @MoveByStick.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMoveByStick;
                @MoveByStick.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMoveByStick;
                @MoveByStick.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMoveByStick;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveByMouse.started += instance.OnMoveByMouse;
                @MoveByMouse.performed += instance.OnMoveByMouse;
                @MoveByMouse.canceled += instance.OnMoveByMouse;
                @SwapCamera.started += instance.OnSwapCamera;
                @SwapCamera.performed += instance.OnSwapCamera;
                @SwapCamera.canceled += instance.OnSwapCamera;
                @MoveByStick.started += instance.OnMoveByStick;
                @MoveByStick.performed += instance.OnMoveByStick;
                @MoveByStick.canceled += instance.OnMoveByStick;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    private int m_PcSchemeIndex = -1;
    public InputControlScheme PcScheme
    {
        get
        {
            if (m_PcSchemeIndex == -1) m_PcSchemeIndex = asset.FindControlSchemeIndex("Pc");
            return asset.controlSchemes[m_PcSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllerXboxSchemeIndex = -1;
    public InputControlScheme ControllerXboxScheme
    {
        get
        {
            if (m_ControllerXboxSchemeIndex == -1) m_ControllerXboxSchemeIndex = asset.FindControlSchemeIndex("ControllerXbox");
            return asset.controlSchemes[m_ControllerXboxSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnSprint(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnSneak(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnTaunt(InputAction.CallbackContext context);
        void OnMoveByMouse(InputAction.CallbackContext context);
        void OnMoveByStick(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnMoveByMouse(InputAction.CallbackContext context);
        void OnSwapCamera(InputAction.CallbackContext context);
        void OnMoveByStick(InputAction.CallbackContext context);
    }
}
