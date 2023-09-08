using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{
    private Vector3 startPosition;
    public float range, movementSpeed;
    private float direction = 1;
    private Rigidbody2D enemyRB;
    PlayerData pd;
    TMP_Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        enemyRB = GetComponent<Rigidbody2D>();
        pd = GameObject.Find("PlayerData").GetComponent<PlayerData>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemyRB.transform.Translate(new Vector2(direction, 0) * movementSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.name.Equals("Player") && coll.transform.position.y < enemyRB.transform.position.y + 1) {
            pd.changeLives(-1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (coll.gameObject.name.Equals("Player") && coll.transform.position.y > enemyRB.transform.position.y + 1) {
            this.gameObject.SetActive(false);
        }
        if (!coll.gameObject.name.Equals("Player")) {
            movementSpeed = -movementSpeed;
        }

    }
}
