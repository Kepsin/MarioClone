using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnter : MonoBehaviour
{
    LevelTransition lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GameObject.Find("LevelTransition").GetComponent<LevelTransition>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other) {
        if(Input.GetButtonDown("Jump")) {
            Debug.Log(gameObject.name);
            lt.setlevelPosition(this.gameObject.transform.position);
            SceneManager.LoadScene(this.gameObject.name, LoadSceneMode.Single);
        }
    }
}
