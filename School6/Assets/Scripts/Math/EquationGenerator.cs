using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equation
{
    public Operation[] operations;
    public int[] args;
    public int answer;

    public Equation(Operation[] _operations, int[] _args, int _answer) 
    {
        operations = _operations;
        args = _args;
        answer = _answer;
    }
}

public enum Operation
{
    Add,
    Substract,
    Multiply,
    Divide
}

public class EquationGenerator : MonoBehaviour
{
 
    public Equation GenerateEquation()
    {
        int numbersCount = Random.Range(2, 6);

        Operation[] operations = new Operation[numbersCount - 1];
        int[] args = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            if(i != 0)
            {
                operations[i - 1] = GenerateOperation();
            }
            args[i] = GenerateNumber(operations, args, i);
        }

        int answer = GenerateAnswer(operations, args);

        Equation eq = new Equation(operations, args, answer);
        return eq;
    }

    public int GenerateNumber(Operation[] operationsArray, int[] numbers, int index)
    {
        int number = Random.Range(1, 24);

        if(index != 0)
        {
            if (operationsArray[index - 1] == Operation.Divide)
            {
                while ((numbers[index - 1] % number) != 0)
                {
                    number = Random.Range(1, 24);
                }
            }
        }
        return number;
    }

    public Operation GenerateOperation()
    {
      
        Operation op = Operation.Add;
        int randomInt = Random.Range(1, 5);

        switch (randomInt)
        {
            case 1:
                op = Operation.Add; 
                break;
            case 2:
                op = Operation.Substract;
                break;
            case 3:
                op = Operation.Multiply;
                break;
            case 4:
                op = Operation.Divide;
                break;
        }
        return op;
    }

    public int GenerateAnswer(Operation[] operationsArray, int[] numbers)
    {
        int answer = numbers[0];
        for (int i = 0; i < operationsArray.Length; i++)
        {
            switch (operationsArray[i])
            {
                case Operation.Add:
                    answer += numbers[i + 1];
                    break;
                case Operation.Substract:
                    answer -= numbers[i + 1];
                    break;
                case Operation.Multiply:
                    break;
                case Operation.Divide:
                    break;
            }
        }
        return answer;
    }
}
