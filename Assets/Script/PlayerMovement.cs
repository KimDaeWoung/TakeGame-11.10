using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float turnSpeed = 120.0f;


    Rigidbody rigidBody;

    Vector2 moveInput;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void FixedUpdate()
    {
        Vector3 move = moveSpeed * transform.forward * moveInput.y * Time.fixedDeltaTime;
        rigidBody.MovePosition(rigidBody.position + move);

        float angle = moveInput.x * turnSpeed * Time.fixedDeltaTime;
        rigidBody.MoveRotation(rigidBody.rotation * Quaternion.Euler(0, angle, 0 ));
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = 0;
        moveInput.y = 0;

        Keyboard Keyboard = Keyboard.current;
        if (Keyboard.wKey.isPressed == true)
        {
            moveInput.y = 1;
            //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }

        if (Keyboard.aKey.isPressed == true)
        {
            moveInput.x = -1;
            // transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        }

        if (Keyboard.sKey.isPressed == true)
        {
            moveInput.y = -1;
            //transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }

        if (Keyboard.dKey.isPressed == true)
        {
            moveInput.x = 1;
            //transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
    }
}
