using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle : Figure
{
    private int radius;

    public Circle(int value) { radius = value; }

    public override float PerimeterCalculation()
    {
        if (radius <= 0)
        {
            return 0;
        }
        return 2 * radius * Mathf.PI;
    }

    public override float AreaCalculation()
    {
        if (radius <= 0)
        {
            return 0;
        }
        return Mathf.Pow(radius, 3) * Mathf.PI;
    }

    public void SetSideValue(int value) { radius = value; }

}
