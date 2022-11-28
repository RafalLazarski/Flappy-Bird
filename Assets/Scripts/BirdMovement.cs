using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Bird;
    [SerializeField] private float SpeedJump;
    private float JumpTeleportRange = 5.5f;

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bird.velocity = new Vector2(0, SpeedJump);
        }

        if (Bird.position.y < -JumpTeleportRange)
        {
            Bird.position = new Vector2(0, JumpTeleportRange);
        }
        if (Bird.position.y > JumpTeleportRange)
        {
            Bird.position = new Vector2(0, -JumpTeleportRange);
        }
    }
}
