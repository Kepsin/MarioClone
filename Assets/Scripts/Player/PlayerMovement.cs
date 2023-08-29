using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player;

    private float jump, horizontal;

    public float moveSpeed = 10.0f;
    // Update is called once per frame
    void Start() {
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        jump = Input.GetAxis("Jump");

        player.transform.Translate(new Vector2(horizontal, jump) * moveSpeed * Time.deltaTime);


    }
}
