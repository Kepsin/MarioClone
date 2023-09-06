using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    Rigidbody2D coinRB;
    GameObject coinGO;
    PlayerData pd;
    public TMP_Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        coinRB = this.GetComponent<Rigidbody2D>();
        coinGO = this.gameObject;
        pd = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        coinText.text = pd.getCoins().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coinRB.rotation += 1.0f;
    }

    void OnTriggerEnter2D(Collider2D other) {


        
        if(other.gameObject.name.Equals("Player")) {
            coinGO.SetActive(false);
            pd.addCoins(1);
            coinText.text = pd.getCoins().ToString();
        }

    }

}
