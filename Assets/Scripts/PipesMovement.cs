using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    private Rigidbody2D PipesRB2D;

    public float speed = 5.0f;

    void Start()
    {
        PipesRB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PipesRB2D.velocity = new Vector2(-speed, 0);

        if (PipesRB2D.position.x < -11.0f)
        {
            Destroy(gameObject);
        }
    }
}
