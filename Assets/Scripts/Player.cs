using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    private float speed = 10.0f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
    	float moveX = Input.GetAxisRaw(PlayerAnimationParameters.axisXinput);

        animator.SetFloat(PlayerAnimationParameters.moveX, moveX);

        bool isMoving = !Mathf.Approximately(moveX, 0f);

        animator.SetBool(PlayerAnimationParameters.isMoving, isMoving);
    }

    void FixedUpdate()
    {
        float forceX = animator.GetFloat(PlayerAnimationParameters.forceX);

        if (forceX != 0) rb.AddForce(new Vector2(forceX, 0) * Time.deltaTime);

        float impulseY = animator.GetFloat(PlayerAnimationParameters.impulseY);

        if (impulseY != 0) rb.AddForce(new Vector2(0, impulseY), ForceMode2D.Impulse);
    }
}
