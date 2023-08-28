using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player;
    // Update is called once per frame
    void Start() {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            player.AddForce(transform.up * 100);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            player.AddForce(transform.right * 100);
        }
    }
}
