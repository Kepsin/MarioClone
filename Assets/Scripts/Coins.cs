using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    Rigidbody2D coinRB;
    GameObject coinGO;
    PlayerData pd;

    // Start is called before the first frame update
    void Awake() {

    }
    void Start()
    {
        coinRB = this.GetComponent<Rigidbody2D>();
        coinGO = this.gameObject;
        pd = GameObject.Find("PlayerData").GetComponent<PlayerData>();
    }

    // Update is called once per frame
    void Update()
    {
        coinRB.rotation += 1.0f;
    }

    void OnTriggerEnter2D(Collider2D other) {


        
        if(other.gameObject.name.Equals("Player")) {
            coinGO.SetActive(false);
            pd.changeCoins(1);
        }

    }

}
