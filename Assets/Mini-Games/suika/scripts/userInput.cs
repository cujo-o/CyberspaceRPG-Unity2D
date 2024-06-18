using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class userInput : MonoBehaviour
{
    public static PlayerInput PlayerInput;

    public static Vector2 moveInput { get; set; }

    public static bool IsthrowPressed { get; set; }

    private InputAction moveAction;
    private InputAction throwAction;

   private void Awake()
    {
        PlayerInput = GetComponent<PlayerInput>();
        moveAction = PlayerInput.actions["Move"];
        throwAction = PlayerInput.actions["Throw"];
    }
    // Update is called once per frame
    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        IsthrowPressed = throwAction.WasPressedThisFrame();
    }
}
