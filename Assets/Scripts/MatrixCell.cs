using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatrixCell : MonoBehaviour
{
   
    public void DataAcquisition(int i ,int j )
    {
         int.TryParse(GetComponent<InputField>().text, out int x);
         Arrays.canvas.Filling(x,i,j);
    }


}
