using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class Movement3D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;

    private PlayerInputActions inputActions;
    private Vector2 moveInput;
    private Vector2 lookInput;
    private CharacterController controller;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        controller = GetComponent<CharacterController>();
    }

//    private void OnEnable()
//    {
//        inputActions.Player.Enable();

//        inputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
//        inputActions.Player.Move.canceled += ctx => moveInput = Vector2.zero;

//        inputActions.Player.Move.performed += ctx => lookInput = ctx.ReadValue<Vector2>();
//        inputActions.Player.Move.performed += ctx => lookInput = Vector2.zero;
//    }
}