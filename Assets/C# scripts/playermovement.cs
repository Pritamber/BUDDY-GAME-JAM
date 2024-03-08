using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class playermovement : MonoBehaviour
{
   
    private InputActionAsset action;
    InputActionMap player;
    public BUDDYGAMEJAM playerinputscript;

    [Header("Input values")]
    [SerializeField] private float speed;

    private Rigidbody2D rb;
    private Vector2 direction;
    private void Awake()
    {
        playerinputscript= new BUDDYGAMEJAM();
        action=this.GetComponent<PlayerInput>().actions;
        player = action.FindActionMap("Player");

        rb= GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        player.Enable();
    }
    private void OnDisable()
    {
        player.Disable();    
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        direction=context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity=new Vector2 (direction.x, direction.y);
    }
}
