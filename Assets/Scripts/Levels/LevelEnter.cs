using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other) {
        if(Input.GetButtonDown("Jump")) {
            Debug.Log("Working");
            SceneManager.LoadScene(gameObject.name, LoadSceneMode.Single);
        }
    }
}
