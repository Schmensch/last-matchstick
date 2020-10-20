using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform CameraView;

    private Vector3 direction;
    private float speed = 4f;

    private Rigidbody rigidBody;
    private float jumpPower = 5f;
    private float WalkingSpeedMultiplier = 1.5f;
    public float y;

    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetInput();
        y = direction.y;
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void GetInput()
    {
        direction = Vector3.zero;

        /* Jumping disabled, not needen in Game.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity += Vector3.up * jumpPower;
        }
        */

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (Camera.main.transform.forward * speed * Time.deltaTime) * WalkingSpeedMultiplier;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + ((Camera.main.transform.right * -1) * speed * Time.deltaTime) * WalkingSpeedMultiplier;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + ((Camera.main.transform.forward * -1) * speed * Time.deltaTime) * WalkingSpeedMultiplier;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (Camera.main.transform.right * speed * Time.deltaTime) * WalkingSpeedMultiplier;
        }
    }
}