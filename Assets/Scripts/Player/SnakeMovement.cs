using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{

    //[SerializeField] private Transform snakeHead;
    [SerializeField] private float _snakeSpeed;
    [SerializeField] private float _distance;
    private Vector2 moveDirection = Vector2.up; 

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        SetDirection();
        //transform.Translate(transform.forward * _snakeSpeed * Time.deltaTime);
    }

    private void SetDirection()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveDirection = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveDirection = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveDirection = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDirection = Vector2.down;
        }
        transform.Translate(moveDirection * _snakeSpeed * Time.deltaTime);
    }
}
