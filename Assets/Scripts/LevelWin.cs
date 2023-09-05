using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LevelWin : MonoBehaviour
{
    public TMP_Text win;
    // Start is called before the first frame update
    void Start()
    {
        win.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollision2D(Collision2D col) {
        Debug.Log("Test");
        if (col.gameObject.name.Equals("Player")) {
            win.enabled = true;
            this.gameObject.SetActive(false);
        }
    }
}
