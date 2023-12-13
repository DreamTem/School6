using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicScore : MonoBehaviour
{
    private Text txt;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }
    
    public void AddScore(int toAdd)
    {
        score += toAdd;
        txt.text = "Score: " + score.ToString(); 
    }
}
