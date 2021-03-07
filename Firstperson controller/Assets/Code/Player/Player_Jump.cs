using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Jump : MonoBehaviour
{
    public float jump_force;
    public bool continuous;
    public float groundDistance = 0.4f, wallDistance = 0.4f;
    public float horizontalForce, hMultiplier, verticalForce, vMultiplier;
    public LayerMask ground, wall;

    float jumpingForce;
    Transform ground_Check, LWall_Check, RWall_Check;
    bool onGround, onWallL, onWallR;

    PlayerInputs inputs;

    private void Awake()
    {
        inputs = new PlayerInputs();
        ground_Check = GameObject.FindGameObjectWithTag("Player_GCheck").transform;
        LWall_Check = GameObject.FindGameObjectWithTag("Player_LWallCheck").transform;
        RWall_Check = GameObject.FindGameObjectWithTag("Player_RWallCheck").transform;

        jumpingForce = jump_force;

        inputs.Gamepadcontrols.Jump.performed += ctx => Jump();
    }

    private void FixedUpdate()
    {
        onGround = Physics.CheckSphere(ground_Check.position, groundDistance, ground);
        onWallL = Physics.CheckSphere(LWall_Check.position, wallDistance, wall);
        onWallR = Physics.CheckSphere(RWall_Check.position, wallDistance, wall);
    }

    private void Jump() 
    {
        if(onGround && !continuous)
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpingForce, 0f), ForceMode.Impulse);
        else if(continuous)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpingForce, 0f), ForceMode.Impulse);
        }

        if (onWallL) this.GetComponent<Rigidbody>().AddForce(new Vector3(horizontalForce * hMultiplier, verticalForce * vMultiplier, 0f), ForceMode.Impulse);
        if (onWallR) this.GetComponent<Rigidbody>().AddForce(new Vector3(-horizontalForce * hMultiplier, verticalForce * vMultiplier, 0f), ForceMode.Impulse);
    }

    public float SetJump(float h) => jumpingForce = h;

    private void OnEnable()
    {
        inputs.Gamepadcontrols.Enable();
    }
    private void OnDisable()
    {
        inputs.Gamepadcontrols.Disable();
    }

}
