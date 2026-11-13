using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float turnSpeed = 120.0f;
    public AudioSource moveAudioSrc;
    public AudioClip drivingClip;
    public AudioClip idletClip;


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

        bool ispressed = false;

        Keyboard Keyboard = Keyboard.current;

        //if(Keyboard.shiftKey.isPressed == true)
        //{
        //    if (Keyboard.wKey.isPressed == true)
        //         {
        //           moveSpeed += 15f;
        //         }
        //}

        if (Keyboard.shiftKey.isPressed == true)
        {
            if (Keyboard.wKey.isPressed == true)
            {
                if(moveSpeed == 5f)
                {
                    moveSpeed += 15f;
                }

            }
        }
        if (Keyboard.shiftKey.isPressed == false)
        {
            if(moveSpeed != 5f)
            {
                moveSpeed = 5f;
            }
        }


            if (Keyboard.wKey.isPressed == true)
        {
            moveInput.y = 1;
            ispressed = true;
            //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }

        if (Keyboard.aKey.isPressed == true)
        {
            moveInput.x = -1;
            ispressed = true;
            // transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        }

        if (Keyboard.sKey.isPressed == true)
        {
            moveInput.y = -1;
            ispressed = true;
            //transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }

        if (Keyboard.dKey.isPressed == true)
        {
            moveInput.x = 1;
            ispressed = true;
            //transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }

        //if (moveInput.x != 0 || moveInput.y != 0)
        if(ispressed == true)
        {
            if(moveAudioSrc.clip != drivingClip)
            {
                moveAudioSrc.clip = drivingClip;
                moveAudioSrc.Play();
            }
           
        }
        else
        {
            if (moveAudioSrc.clip != idletClip)
            {
                moveAudioSrc.clip = idletClip;
                moveAudioSrc.Play();
            }
        }
    }
}
