using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HorseMovement : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;

    private Rigidbody rb;
    private float movementInputValue;
    private float turnInputValue;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        HorseMove();
        HorseTurn();
    }

    void HorseMove()
    {
        movementInputValue = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * movementInputValue * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    void HorseTurn()
    {
        turnInputValue = Input.GetAxis("Horizontal");
        float turn = turnInputValue * turnSpeed * Time.deltaTime;
        Quaternion turnRptation = Quaternion.Euler(0, turn, 0);
        rb.MoveRotation(rb.rotation * turnRptation);
    }
}
