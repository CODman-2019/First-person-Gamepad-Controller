using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public float walk, run, hipSpeed, aimSpeed;
    public float groundDistance = 0.4f;
    public LayerMask groundMask; 

    PlayerInputs inputs;

    Transform ground_Check;
    float speed, camSpeed;
    Vector2 move, look;
    bool canMove, canSprint, onGround;
    Rigidbody rb;

    void Awake()
    {
        ground_Check = GameObject.FindGameObjectWithTag("Player_GCheck").transform;
        rb = this.GetComponent<Rigidbody>();
        speed = walk;
        camSpeed = hipSpeed;

        inputs = new PlayerInputs();

        inputs.Gamepadcontrols.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        inputs.Gamepadcontrols.Move.canceled += ctx => move = Vector2.zero;

        inputs.Gamepadcontrols.Look.performed += ctx => look = ctx.ReadValue<Vector2>();
        inputs.Gamepadcontrols.Look.canceled += ctx => look = Vector2.zero;

        inputs.Gamepadcontrols.Sprinttoggle.performed += ctx => ChangeSpeed();

        inputs.Gamepadcontrols.AimDown.performed += ctx => camSpeed = aimSpeed;
        inputs.Gamepadcontrols.AimDown.canceled += ctx => camSpeed = hipSpeed;
    }

    void ChangeSpeed()
    {
        if (speed == walk) speed = run;
        else speed = walk;
    }

    //void ChangeCameraSpeed()
    //{
    //    if (speed == hipSpeed) speed = aimSpeed;
    //    else speed = hipSpeed;
    //}

    // Update is called once per frame
    void Update()
    {
        onGround = Physics.CheckSphere(ground_Check.position, groundDistance, groundMask);

        transform.Translate(move.x * speed * Time.deltaTime, 0f, move.y * speed * Time.deltaTime);
        //rb.AddForce(new Vector3(move.x * speed * Time.deltaTime, 0f, move.y * speed * Time.deltaTime), ForceMode.Force);
        transform.Rotate(0f, look.x * camSpeed * Time.deltaTime, 0f);
    }


    public bool SetCanMove(bool setting) => canMove = setting;
    public bool SetCanSprint(bool setting) => canSprint = setting;
    public bool GetCanMove() => canMove;
    public bool GetCanSprint() => canSprint;


    private void OnEnable()
    {
        inputs.Gamepadcontrols.Enable();
    }
    private void OnDisable()
    {
        inputs.Gamepadcontrols.Disable();
    }

}
