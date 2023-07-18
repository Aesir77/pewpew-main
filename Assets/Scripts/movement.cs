using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class movement : MonoBehaviour
{
    public int moveSpeed;
    public Rigidbody2D rigidBody;
    public Animator anim;
    public int health;
    public int ammo;
    public float hInput;
    private Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //hInput = Input.GetAxisRaw("Horizontal");

        //transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);
        anim.SetFloat("Horizontal", move.x);
        anim.SetFloat("Speed", move.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        rigidBody.velocity = move * moveSpeed;
    }
    private void OnMove(InputValue inputValue)
    {
        move = inputValue.Get<Vector2>();

    }
}
