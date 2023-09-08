using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    [SerializeField]
    private int coins;
    private int lives;
    TMP_Text coinText, livesText;

    void Awake() {
        if (Instance != null)
        {
        Destroy(gameObject);
        return;
        }
        Instance =  this;
        DontDestroyOnLoad(gameObject);

    }
    void Start() {
        lives = 5;
        coins = 96;
        coinText = GameObject.Find("Coin_Total").GetComponent<TMP_Text>();
        coinText.text = coins.ToString();

        livesText = GameObject.Find("Lives").GetComponent<TMP_Text>();
        livesText.text = lives.ToString();
    }

    public int getCoins() {
        return coins;
    }

    public void changeCoins(int var) {
        coins += var;
        if (coins == 100) {
            changeLives(1);
            coins = 0;
        }
        coinText.text = coins.ToString();
    }
    public int getLives() {
        return lives;
    }
    public void changeLives(int var) {
        lives += var;
        livesText.text = lives.ToString();
    }
    public void setLivesText(TMP_Text text) {
        livesText = text;
    }
    public void setCoinsText(TMP_Text text) {
        coinText = text;
    }
}
