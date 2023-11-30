using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public string levelName;

    public void Load()
    {
        SceneManager.LoadScene(levelName);
    }
}
