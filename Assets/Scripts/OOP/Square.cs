using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : Figure
{

    private int side;
    public Square(int value) { side = value; }

    public  float PerimeterCalculation()
    {
        if (side <= 0)
        {
            return 0;
        }
        return side * 4;
    }

    public  float AreaCalculation()
    {
        if (side <= 0)
        {
            return 0;
        }
        return side * side; ;
    }

    public void SetSideValue(int value) { side = value; }
   
}
