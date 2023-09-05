using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;

    private float horizontal;

    [SerializeField]
    private float moveSpeed;
    // Update is called once per frame
    void Start() {
        moveSpeed = 10;
        player = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {        
        horizontal = Input.GetAxis("Horizontal");

        player.transform.Translate(new Vector2(horizontal, 0) * moveSpeed * Time.deltaTime);
    }
}
