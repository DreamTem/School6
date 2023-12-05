using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class EquationsSystem : MonoBehaviour
{
    private EquationGenerator generator;

    private LevelLoader loader;

    public Text text;
    
    public InputField iField;
    
    Equation currentEquation;
    
    public SocialCredit creditSystem;
    
    private int completedQuestions = 0;

    public VideoPlayer player;

    public VideoClip correct, incorrect;

    public GameObject videoTexture;

    public Image finalImage;

    public Sprite success, notSuccess;

    public AudioSource source;

    public AudioClip victorySound, loseSound;

    private void Start()
    {
        generator = GetComponent<EquationGenerator>();
        loader = GetComponent<LevelLoader>();

        NextQuestion();
    }
    public void NextQuestion()
    {
        currentEquation = generator.GenerateEquation();
        for (int i = 0; i < currentEquation.args.Length; i++)
        {
            text.text += currentEquation.args[i].ToString();
            if (i != (currentEquation.args.Length - 1))
            {
                switch (currentEquation.operations[i])
                {
                    case Operation.Add:
                        text.text += " + ";
                        break;
                    case Operation.Substract:
                        text.text += " - ";
                        break;
                    case Operation.Multiply:
                        text.text += " * ";
                        break;
                    case Operation.Divide:
                        text.text += " / ";
                        break;
                }
            }
        }
        text.text += "?";
    }

    public void SubmitAnswer()
    {
        if (completedQuestions == 10) return;

        int ans = int.Parse(iField.text);

        if(ans == currentEquation.answer)
        {
            creditSystem.UpdateCredit(100);
            if((completedQuestions + 1) != 10)
            {
                ShowVideo(true);
            }
        }
        else
        {
            creditSystem.UpdateCredit(-100);
            if ((completedQuestions + 1) != 10)
            {
                ShowVideo(false);
            }
        }
        completedQuestions++;

        if(completedQuestions == 10)
        {
            StartCoroutine(EndLevel());
        }
        else
        {
            text.text = "";
            NextQuestion();
            iField.text = "";
        }
        
    }

    private void ShowVideo(bool corr)
    {
        if (corr)
        {
            player.clip = correct;
            Invoke("DisableVideo", 3);
        }
        else
        {
            player.clip = incorrect;
            Invoke("DisableVideo", 2);
        }
        player.Play();
        videoTexture.SetActive(true);
    }

    private void DisableVideo()
    {
        videoTexture.SetActive(false);
    }
    private IEnumerator EndLevel()
    {
        if(creditSystem.socialCredit >= 500)
        {
            finalImage.sprite = success;
            source.clip = victorySound;
        }
        else
        {
            finalImage.sprite = notSuccess;
            source.clip = loseSound;
        }
        source.Play();
        finalImage.gameObject.SetActive(true);

        yield return new WaitForSeconds(4);

        loader.Load();
    } 
}
