using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    private Rigidbody2D player;
    [SerializeField]
    private float jump;
    Vector2 vecGravity;

    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded()) {
            player.velocity = new Vector2(player.velocity.x, jump);
        }
    }

    bool isGrounded() {
        return Physics2D.IsTouchingLayers(this.GetComponent<BoxCollider2D>(), groundLayer);
    }
}
