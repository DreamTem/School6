using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EquationsSystem : MonoBehaviour
{
    private EquationGenerator generator;
    public Text text;
    Equation currentEquation;


    private void Start()
    {
        generator = GetComponent<EquationGenerator>();

        currentEquation = generator.GenerateEquation();
        for (int i = 0; i < currentEquation.args.Length; i++)
        {
            text.text += currentEquation.args[i].ToString();
            if(i != (currentEquation.args.Length - 1))
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

    public void SubmitAnswer(string input)
    {
        int ans = int.Parse(input);

        if(ans == currentEquation.answer)
        {

        }
    }
}
