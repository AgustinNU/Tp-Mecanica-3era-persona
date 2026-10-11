using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JugadorScript : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    public float jumpForce = 10f;
    public bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -speed));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-speed, 0, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(speed, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    }

}
