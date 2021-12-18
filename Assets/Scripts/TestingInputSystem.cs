using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{
    private void Awake()
    {
        PlayerInputActions playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();
        playerInputActions.Player.Shoot.performed += ShootOnperformed;
    }

    private void ShootOnperformed(InputAction.CallbackContext obj)
    {
        Debug.Log("Ding!");
    }
}
