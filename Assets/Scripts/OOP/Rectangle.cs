using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rectangle : Figure
{

    private int sideA;
    private int sideB;

    public Rectangle(int value, int value_2) { sideA = value; sideB = value_2; }

    public  float PerimeterCalculation()
    {
        if (sideA <= 0 || sideB <= 0)
        {
            return 0;
        }
        return (sideA * 2) + (sideB * 2);
    }

    public  float AreaCalculation()
    {
        if (sideA <= 0 || sideB <= 0)
        {
            return 0;
        }
        return sideA * sideB;
    }

    public void SetSideValue(int value, int value_2) { sideA = value; sideB = value_2; }


}