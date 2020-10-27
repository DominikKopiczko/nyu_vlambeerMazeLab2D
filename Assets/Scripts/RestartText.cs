using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartText : MonoBehaviour
{
    public Text restartText;
    Color textColor;
    // Start is called before the first frame update
    void Start()
    {
        restartText.text = "Press R To Generate New Maze !";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
