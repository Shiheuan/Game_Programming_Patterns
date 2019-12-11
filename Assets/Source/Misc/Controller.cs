using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Controller : MonoBehaviour
{
    public CharacterController _controller;
    private float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))

        {
            _controller.SimpleMove(Vector3.right * (-moveSpeed));

        }


        if (Input.GetKey(KeyCode.D))

        {
            _controller.SimpleMove(Vector3.right * moveSpeed);

        }


        if (Input.GetKey(KeyCode.W))

        {
            _controller.SimpleMove(Vector3.forward * moveSpeed);  
        }


        if (Input.GetKey(KeyCode.S))

        {
            _controller.SimpleMove(Vector3.forward * (-moveSpeed));
        }


    }
}
