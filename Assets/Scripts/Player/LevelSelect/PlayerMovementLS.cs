using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementLS : MonoBehaviour
{
    Rigidbody2D player;
    float horizontal, moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10;
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        player.transform.Translate(new Vector2(horizontal, 0) * moveSpeed * Time.deltaTime);
    }
}
