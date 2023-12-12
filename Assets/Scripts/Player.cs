using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    private float speed = 10.0f;

    void Start()
    {

    }


    void Update()
    {
    	float moveX = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("moveX", moveX);

        bool isMoving = !Mathf.Approximately(moveX, 0f);

        animator.SetBool("isMoving", isMoving);
    }
}
