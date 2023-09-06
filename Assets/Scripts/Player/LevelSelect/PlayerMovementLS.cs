using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementLS : MonoBehaviour
{
    Rigidbody2D player;
    float horizontal, vertical, moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10;
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        player.transform.Translate(new Vector2(horizontal, vertical) * moveSpeed * Time.deltaTime);
    }

}
