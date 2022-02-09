using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Algorithms : MonoBehaviour
{
    [SerializeField] private GameObject InputFieldExponentiate_number;
    [SerializeField] private GameObject InputFieldExponentiate_degree;
    [SerializeField] private GameObject InputFieldFibonacci;
    [SerializeField] private Text AnswerExponentiate;
    [SerializeField] private Text AnswerFibonacci;

    long Fibonacci(int index)
    {

        if (index <= 0)
        {
            Debug.LogWarning("Error");
            return 0;
        }

        long x0 = 0;
        long x1 = 1;
        long x2 = 1;

        for (int i = 2; i < index; i++)
        {
            x2 = x1 + x0;
            x0 = x1;
            x1 = x2;
        }

        if (index == 1)
        {
            
            return x0;
        }
        if (index == 2)
        {

            return x1;
        }

        return x2;
    }

    public void SetValueFibonacci()
    {
        int.TryParse(InputFieldFibonacci.GetComponent<InputField>().text, out int x);
        AnswerFibonacci.text =""+ Fibonacci(x);
    }




    int Exponentiate(int x, int  y)
    {
        if (y > 1)
        {       
            x *= Exponentiate(x, y -1);
        }

        return x;
    }

    public void SetValueExponentiate()
    {
        int.TryParse(InputFieldExponentiate_number.GetComponent<InputField>().text, out int x);
        int.TryParse(InputFieldExponentiate_degree.GetComponent<InputField>().text, out int y);
        AnswerExponentiate.text = "" + Exponentiate(x,y);
    }
}
