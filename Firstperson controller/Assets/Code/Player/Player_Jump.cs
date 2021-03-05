using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Jump : MonoBehaviour
{
    public float jump_force;
    public bool continuous;
    public float groundDistance = 0.4f;
    public LayerMask ground;

    float jumpingForce;
    Transform ground_Check;
    bool onGround;

    PlayerInputs inputs;

    private void Awake()
    {
        inputs = new PlayerInputs();
        ground_Check = GameObject.FindGameObjectWithTag("Player_GCheck").transform;

        jumpingForce = jump_force;

        inputs.Gamepadcontrols.Jump.performed += ctx => Jump();
    }

    private void FixedUpdate()
    {
        onGround = Physics.CheckSphere(ground_Check.position, groundDistance, ground);
    }

    private void Jump() 
    {
        if(onGround && !continuous)
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpingForce, 0f), ForceMode.Impulse);
        else
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpingForce, 0f), ForceMode.Impulse);
        }
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
