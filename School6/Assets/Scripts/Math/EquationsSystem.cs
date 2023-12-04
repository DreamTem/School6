using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EquationsSystem : MonoBehaviour
{
    private EquationGenerator generator;
    public Text text;
    public InputField iField;
    Equation currentEquation;
    public SocialCredit creditSystem;
    private int completedQuestions = 0;

    private void Start()
    {
        generator = GetComponent<EquationGenerator>();
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
        }
        else
        {
            creditSystem.UpdateCredit(-100);
        }
        completedQuestions++;

        if(completedQuestions == 10)
        {
            EndLevel();
        }
        else
        {
            text.text = "";
            NextQuestion();
            iField.text = "";
        }
        
    }

    private void EndLevel()
    {

    } 
}
