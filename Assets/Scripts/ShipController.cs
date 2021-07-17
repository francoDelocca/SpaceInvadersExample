using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipController : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private Vector2 movement;

    [Header("Speed")]
    public float speed = 2f;

    [Header("Limite Speed")]
    public float limitSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        movement = new Vector2(moveHorizontal, 0f);
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(movement * speed * 5f);

        if (rigidbody.velocity.x >= limitSpeed)
        {
            rigidbody.velocity = new Vector2(limitSpeed, 0f);
        }
        else if (rigidbody.velocity.x <= (limitSpeed * -1))
        {
            rigidbody.velocity = new Vector2((limitSpeed * -1), 0f);
        }

    }
}
