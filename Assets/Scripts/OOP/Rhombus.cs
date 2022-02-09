using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rhombus : Figure
{
    private int side;
    private int angle;

    public Rhombus(int value, int value_2) { side = value; angle = value_2; }

    public override float PerimeterCalculation()
    {
        if (side <= 0 || angle <= 0)
        {
            return 0;
        }
        return side * 4;
    }

    public override float AreaCalculation()
    {
        if (side <= 0 || angle <= 0)
        {
            return 0;
        }
        return side * side * Mathf.Sin(angle);
    }

    public void SetSideValue(int value, int value_2) { side = value; angle = value_2; }

}
