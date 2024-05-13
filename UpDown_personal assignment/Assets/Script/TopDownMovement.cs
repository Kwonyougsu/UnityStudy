using System;
using Unity.VisualScripting;
using UnityEngine;

public partial class TopDownMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D movement;
    private Vector2 movementDirection = Vector2.zero;

    private void Awake() // 주로 컴포넌트안에 종료가 된다
    {
        //컨트롤러 == 탑타운 컨트롤러
        controller = GetComponent<TopDownController>();
        movement = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movement.velocity = direction;

    }
}
