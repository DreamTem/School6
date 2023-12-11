using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Zelenskiy : MonoBehaviour
{
    public GameObject imageToEnable;
    private LevelLoader loader;
    public VideoPlayer player;

    private int parts = 0;

    // Start is called before the first frame update
    void Start()
    {
        loader = GetComponent<LevelLoader>();
    }

    public void AddPart()
    {
        parts++;
        if(parts == 4)
        {
            StartCoroutine(EndLevel());
        }
    }
    private IEnumerator EndLevel()
    {
        player.Play();
        imageToEnable.SetActive(true);
        yield return new WaitForSeconds(10);
        loader.Load();
    }
}
