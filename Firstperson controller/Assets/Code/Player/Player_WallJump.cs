using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_WallJump : MonoBehaviour
{

    public LayerMask wall;
    public float wallDistance = 0.4f;
    public float horizontalForce, verticalForce;
    Transform LWall_Check, RWall_Check;
    bool onWall;
    PlayerInputs inputs;

    private void Awake()
    {
        LWall_Check = GameObject.FindGameObjectWithTag("Player_LWallCheck").transform;
        RWall_Check = GameObject.FindGameObjectWithTag("Player_RWallCheck").transform;

        inputs = new PlayerInputs();

        inputs.Gamepadcontrols.Jump.performed += ctx => WallJump();
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        onWall = Physics.CheckSphere(LWall_Check.position, wallDistance, wall);
        onWall = Physics.CheckSphere(RWall_Check.position, wallDistance, wall);
    }

    private void WallJump()
    {

    }
}
