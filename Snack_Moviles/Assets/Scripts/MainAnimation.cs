using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAnimation : MonoBehaviour
{
    private Vector3 moveDirection;
    public Animator animatorMan;
    private CharacterController cController;
    public float walkSpeed;

    void Start()
    {
        animatorMan = GetComponent<Animator>();
        cController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        moveDirection = new Vector3(walkSpeed, 0, 0);
        cController.Move(moveDirection * Time.deltaTime);
    }
}
