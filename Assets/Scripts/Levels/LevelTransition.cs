using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public static LevelTransition Instance;
    [SerializeField]
    Vector2 levelPosition;
    [SerializeField]
    GameObject Player, UI;
    PlayerData pd;
    TMP_Text coinsText;
    void Awake() {
        if (Instance != null)
        {
        Destroy(gameObject);
        return;
        }
        Instance =  this;
        pd = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        DontDestroyOnLoad(gameObject);
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        UI = GameObject.Find("Canvas");
        Player = GameObject.Find("Player");
        UI.GetComponentInChildren<TMP_Text>().text = pd.getCoins().ToString();
        if (SceneManager.GetActiveScene().name.Equals("Level Selector")) {
            returnToLevel();
        }
     }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    
    public void setlevelPosition(Vector2 position) {
        levelPosition = position;
    }
    public Vector2 getLevelPosition() {
        return levelPosition;
    }
    public void returnToLevel() {
        if (levelPosition != new Vector2(0, 0)) {
            Player.transform.position = levelPosition;
        }
    }
}
