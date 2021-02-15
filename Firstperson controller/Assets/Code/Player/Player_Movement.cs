using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public float walk, run;

    PlayerInputs inputs;
    float speed;
    Vector2 move, look;

    // Start is called before the first frame update
    void Awake()
    {
        inputs = new PlayerInputs();

        inputs.Gamepadcontrols.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        inputs.Gamepadcontrols.Move.canceled += ctx => move = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
