using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private int coins;

    void Start() {
        coins = 0;
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
