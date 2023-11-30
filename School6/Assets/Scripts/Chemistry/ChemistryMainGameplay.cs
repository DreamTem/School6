using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChemistryMainGameplay : MonoBehaviour
{
    public VideoPlayer player;
    public VideoClip goslingClip;
    public GameObject videoImage;
    private LevelLoader levelLoad;
    // Start is called before the first frame update
    void Start()
    {
        levelLoad = GetComponent<LevelLoader>();
        Invoke("StopPohimichim", 11);
    }

    void StopPohimichim()
    {
        videoImage.SetActive(false);
    }
    public void PlayGosling()
    {
        player.clip = goslingClip;
        player.Play();
        player.SetDirectAudioVolume(0, 0.5f);
        videoImage.SetActive(true);
        Invoke("ExitToMenu", 13);
    }
    private void ExitToMenu()
    {
        levelLoad.Load();
    }
}
