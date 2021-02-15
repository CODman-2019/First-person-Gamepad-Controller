using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public float walk, run, hipSpeed, AimSpeed;

    PlayerInputs inputs;
    float speed;
    Vector2 move, look;
    bool canMove;

    // Start is called before the first frame update
    void Awake()
    {
        speed = walk;
        inputs = new PlayerInputs();

        inputs.Gamepadcontrols.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        inputs.Gamepadcontrols.Move.canceled += ctx => move = Vector2.zero;

        inputs.Gamepadcontrols.Look.performed += ctx => look = ctx.ReadValue<Vector2>();
        inputs.Gamepadcontrols.Look.canceled += ctx => look = Vector2.zero;

        inputs.Gamepadcontrols.Sprinttoggle.performed += ctx => ChangeSpeed();
    }

    void ChangeSpeed()
    {
        if (speed == walk) speed = run;
        else speed = walk;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(move.x * speed * Time.deltaTime, 0f, move.y * speed * Time.deltaTime);
        transform.Rotate(0f, look.x * speed * Time.deltaTime, 0f);
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
