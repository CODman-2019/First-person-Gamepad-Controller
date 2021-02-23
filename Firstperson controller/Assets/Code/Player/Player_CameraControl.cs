using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_CameraControl : MonoBehaviour
{
    public float hipSpeed, aimSpeed, lookRange;
    PlayerInputs inputs;

    float speed, yCamera;
    float xRotation = 0f;
    Vector2 look;
    bool canLook, lookUp, lookDown;

    void Awake()
    {
        speed = hipSpeed;
        lookUp = true;
        lookDown = true;
        
        inputs = new PlayerInputs();

        inputs.Gamepadcontrols.Look.performed += ctx => look = ctx.ReadValue<Vector2>();
        inputs.Gamepadcontrols.Look.canceled += ctx => look = Vector2.zero;

        inputs.Gamepadcontrols.AimDown.performed += ctx => speed = aimSpeed;
        inputs.Gamepadcontrols.AimDown.canceled += ctx => speed = hipSpeed;

    }

    // Update is called once per frame
    void Update()
    {   
        yCamera = look.y * speed * Time.deltaTime;
        xRotation -= yCamera;
        //yCamera= Mathf.Clamp(yCamera, -lookRange, lookRange);
        xRotation = Mathf.Clamp(xRotation, -lookRange, lookRange);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //transform.Rotate(yCamera, 0f, 0f);
        //transform.Rotate(xRotation,0f, 0f);

        //if(transform.rotation.x < -lookRange)
        //{
        //    transform.Rotate(1f, 0f, 0f);
        //}
        //if(transform.rotation.x > lookRange)
        //{
        //    transform.Rotate(-1f, 0f, 0f);
        //}

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

        //if (transform.rotation.x > lookMax)
        //{
        //    look.y = 0;
        //}

        //if(transform.rotation.x < lookMin)
        //{
        //    look.y = 0;
        //}