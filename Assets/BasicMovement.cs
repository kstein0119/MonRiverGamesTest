using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator;
    public bool isGrounded = false;
    public float jumpHeight = 8f;
    // Set default values for moveSpeed and jumpHeight, but also editable in Unity UI

    void Update()
    {
        Jump(); 

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position = transform.position + horizontal * Time.deltaTime * moveSpeed;

    }

    void Jump()
    {

        if (Input.GetButtonDown("Jump") && isGrounded == true) {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);

        }

    }

}
