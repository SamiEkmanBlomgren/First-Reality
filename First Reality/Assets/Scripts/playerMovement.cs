using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector3 moveInput;
    Vector3 velocity;
    [SerializeField] int moveSpeed = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnMove(InputValue Value)
    {
        moveInput = Value.Get<Vector2>();
        Debug.Log(Value);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = rb.linearVelocity;
        velocity.x = moveInput.x*moveSpeed;
        velocity.z = moveInput.y*moveSpeed;
        rb.linearVelocity = velocity;
    }

}
