using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PEGameplayController : MonoBehaviour
{
    private float countdown = 5;

    public Text countdownText;

    public VideoPlayer player;

    public VideoClip clappingClip;

    private bool preGame = true;

    public Text gameRemaining;

    public Arrow arrowPrefab;

    public Vector3 spawnPos;

    public RectTransform clickLevel;

    public Text scoreText;

    public Text peremoga;

    private int score;

    private LevelLoader levelLoad;

    public GameObject dekster;
    // Update is called once per frame
    void Start()
    {
        levelLoad = GetComponent<LevelLoader>();
    }
    void Update()
    {
        if (preGame)
        {
            if (countdown >= 0)
            {
                countdown -= Time.deltaTime;
                countdownText.text = "Початок через: " + Mathf.Round(countdown).ToString();
            }

            else
            {
                StartGame();
            }
        }

        else
        {
            if(countdown >= 0)
            {
                countdown -= Time.deltaTime;
                gameRemaining.text = Mathf.Round(countdown).ToString();
            }

            else
            {
                EndGame();
            }
        }
    }

    private void StartGame()
    {
        dekster.SetActive(true);
        player.Play();
        countdown = 30;
        preGame = false;
        gameRemaining.gameObject.SetActive(true);
        StartCoroutine(SpawnArrows());
    }

    private IEnumerator SpawnArrows()
    {
        while(countdown >= 0)
        {
            SpawnArrow();
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void SpawnArrow()
    {
        Arrow arrow = Instantiate(arrowPrefab, spawnPos, Quaternion.identity);
        arrow.clickLevel = clickLevel;
        arrow.controller = this;

        RectTransform arrowRect = arrow.GetComponent<RectTransform>();
        arrowRect.SetParent(transform);
    }

    public void AddScore(int scoreToAdd)
    {
        if (countdown <= 0) return;
        score += scoreToAdd;
        scoreText.text = "Score: " + score.ToString();
    }

    private void EndGame()
    {
        player.clip = clappingClip;
        player.Play();
        gameRemaining.gameObject.SetActive(false);
        peremoga.gameObject.SetActive(true);
        peremoga.text = "Ви набрали:" +  score.ToString() + " балів!";
        Invoke("ExitToMenu", 5);
    }

    private void ExitToMenu()
    {
        levelLoad.Load();
    }
}
