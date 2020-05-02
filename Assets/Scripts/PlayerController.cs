using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private CharacterController compChar;

    public float speedMove;
    public float mouseSensitivity;

    private float xRotation = 0f;
    public Transform tnsView;

    private Vector3 velocity;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private bool isGrounded;

    public void CompStart() {
        compChar = GetComponent<CharacterController>();
    }

    public void CompUpdate(DataPlayer data) {
        PerformentMovement(data.axis_h, data.axis_v);
        PerformentRotation(data.mouse_x, data.mouse_y);
        PerformentJump(data.jump);
        PerformentGavity();
    }

    private void PerformentJump(bool isJump) {
        if (isJump && isGrounded)
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }

    private void PerformentGavity() {
        isGrounded = Physics.CheckSphere(transform.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
            velocity.y = -2f;

        velocity.y += gravity * Time.deltaTime;
        compChar.Move(velocity * Time.deltaTime);
    }

    public void PerformentMovement(float h, float v) {
        Vector3 axis_x = transform.right * h;
        Vector3 axis_z = transform.forward * v;

        Vector3 direction = (axis_x + axis_z).normalized;
        compChar.Move(direction * speedMove * Time.deltaTime);
    }

    public void PerformentRotation(float mouseX, float mouoseY) {
        float rotation_Y = mouseX * mouseSensitivity * Time.deltaTime; 
        float rotation_X = mouoseY * mouseSensitivity * Time.deltaTime;

        xRotation -= rotation_X;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.Rotate(Vector3.up * rotation_Y);
        tnsView.localRotation = Quaternion.Euler(Vector3.right * xRotation);
    }
}