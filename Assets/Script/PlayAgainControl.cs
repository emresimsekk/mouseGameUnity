using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayAgainControl : MonoBehaviour
{
    public Text timer;
    void Start()
    {
        timer.text = PlayerPrefs.GetString("point");
    }

    
    void Update()
    {
        
    }
}
