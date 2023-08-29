using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private Vector3 startPosition;
    public float range, movementSpeed;
    private float direction = 1;
    private Rigidbody2D enemyRB;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemyRB.transform.Translate(new Vector2(direction, 0) * movementSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.name.Equals("Player") && coll.transform.position.y < enemyRB.transform.position.y + .5) {
            coll.transform.position = new Vector2(0.02f ,-2.48f);
        }
        if (coll.gameObject.name.Equals("Player") && coll.transform.position.y > enemyRB.transform.position.y + .5) {
            this.gameObject.SetActive(false);
        }
        movementSpeed = -movementSpeed;

    }
}
