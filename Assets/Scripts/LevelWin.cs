using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


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

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Triggered");
        if(other.gameObject.name.Equals("Player")) {
            SceneManager.LoadScene("Level Selector", LoadSceneMode.Single);
        }
    }
}
