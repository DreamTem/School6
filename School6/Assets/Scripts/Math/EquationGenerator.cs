using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equation
{
    public Operation[] operations;
    public int[] args;
    
    public Equation(Operation[] _operations, int[] _args) 
    {
        operations = _operations;
        args = _args;
    }
}

public class EquationGenerator : MonoBehaviour
{
    
}
public enum Operation
{
    Add,
    Substract,
    Multiply,
    Divide
}
