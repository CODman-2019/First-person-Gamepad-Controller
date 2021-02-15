﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_CameraControl : MonoBehaviour
{
    public float hipSpeed, AimSpeed;
    PlayerInputs inputs;

    float speed;
    Vector2 look;
    bool canLook;

    void Awake()
    {
        speed = hipSpeed;
        inputs = new PlayerInputs();
        Mathf.Clamp(transform.rotation.x, -90f, 90f);

        inputs.Gamepadcontrols.Look.performed += ctx => look = ctx.ReadValue<Vector2>();
        inputs.Gamepadcontrols.Look.canceled += ctx => look = Vector2.zero;
        
        
    }

    void ChangeCameraSpeed()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(-look.y * speed * Time.deltaTime, 0f, 0f);
        //transform.rotation.z = 0;
    }

    private void OnEnable()
    {
        inputs.Gamepadcontrols.Enable();
    }
    private void OnDisable()
    {
        inputs.Gamepadcontrols.Disable();
    }
}