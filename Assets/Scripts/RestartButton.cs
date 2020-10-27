using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    void Start()
    {
        //Text sets your text to say this message
    }

    // Update is called once per frame
    void Update()
    {
        //Press R to restart
		if (Input.GetKeyDown(KeyCode.R)) {
			FloorMaker.globalTileCount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }	
    }
}
