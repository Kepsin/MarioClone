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

    }

    public int getCoins() {
        return coins;
    }

    public void addCoins(int var) {
        coins += var;
    }
    public void removeCoins(int var) {
        coins -= var;
    }

}
