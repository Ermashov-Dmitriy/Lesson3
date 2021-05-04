using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Player : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float ShiftSpeed;
    [SerializeField] float jump;
    [SerializeField] float gravity;
    float x_Move;
    float z_Move;
    CharacterController player;
    Vector3 move_Direction;
    private void Start()
    {
        player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();  
    }

    private void Move()
    {
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        if (player.isGrounded) 
        {
            move_Direction = new Vector3(x_Move, 0f, z_Move);
            move_Direction = transform.TransformDirection(move_Direction);
            if (Input.GetKey(KeyCode.Space))
            {
                move_Direction.y += jump;
            }
        }
        move_Direction.y -= gravity;
        player.Move(move_Direction * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            player.Move(move_Direction * ShiftSpeed * Time.deltaTime);
        }
        
    }

}
