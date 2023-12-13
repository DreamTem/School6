using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OsuCircle : MonoBehaviour
{
    public Transform borderCircle;

    public float borderSpeed;
    private float lerpValue;

    public MusicScore scoreRef;

    // Update is called once per frame
    void Update()
    {
        lerpValue += borderSpeed * Time.deltaTime;
        borderCircle.localScale = new Vector3(Mathf.Lerp(2, 0.8f, lerpValue), Mathf.Lerp(2, 0.8f, lerpValue), 0);
        if(borderCircle.localScale.x <= 0.8f)
        {
            scoreRef.AddScore(-20);
            Destroy(gameObject);
        }
    }
    public void Click()
    {
        scoreRef.AddScore(CalculateScore());
        Destroy(gameObject);
    }

    private int CalculateScore()
    {
        int scoreToAdd = 0;
        if(borderCircle.localScale.x > 1.6f)
        {
            scoreToAdd = -10;
        }
        else if(borderCircle.localScale.x <= 1.3f && borderCircle.localScale.x > 1)
        {
            scoreToAdd = 10;
        }
        else if(borderCircle.localScale.x <= 1)
        {
            scoreToAdd = 20;
        }
        return scoreToAdd;
    }
}
