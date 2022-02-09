using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Arrays : MonoBehaviour
{
    [SerializeField] private GameObject[,] thisInputWindows;
    [SerializeField] private int[,] matrix;
    [SerializeField] private GameObject infield;
    [SerializeField] private GameObject inputX;
    [SerializeField] private GameObject inputY;
    [SerializeField] private Text Answer;
    private int resDiagonal;
    private int resMultiples;
    private int matrixSizeX;
    private int matrixSizeY;
    public static Arrays canvas;


    void Start()
    {
        canvas = this;
    }

    int Diagonal(int[,] _matrix)
    {
        resDiagonal = 0;
        GetValue(matrixSizeX, matrixSizeY);
    
        if (_matrix.GetLength(0) < _matrix.GetLength(1))
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                resDiagonal += _matrix[i,i];
            }
        }
        else
        {
            for (int i = 0; i < _matrix.GetLength(1); i++)
            {
                resDiagonal += _matrix[i, i];
            }
        }
        return resDiagonal;
    }
    public void PaymentDiagonal()
    {
        int x = Diagonal(matrix);
        Answer.text = "" + x;
    }

    int Multiples(int[,] _matrix)
    {
        resMultiples = 0;
        GetValue(matrixSizeX, matrixSizeY);
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                if (_matrix[i, j] % 3f == 0)
                {
                    resMultiples += _matrix[i, j];
                }
            }          
        }
        return resMultiples;
    }

    public void PaymentMultiples()
    {
        int x = Multiples(matrix);
        Answer.text = "" + x;
    }
    public void ÑreateMatrix()
    {
        if (thisInputWindows != null)
        {
            ClearingTheField();
        }

        int.TryParse(inputX.GetComponent<InputField>().text, out matrixSizeX);
        int.TryParse(inputY.GetComponent<InputField>().text, out matrixSizeY);
        matrix = new int[matrixSizeX, matrixSizeY];
        thisInputWindows = new GameObject[matrixSizeX, matrixSizeY];
        CreateInputField(matrixSizeX, matrixSizeY);
    }

    public void Filling(int x,int i, int j)
    {
        matrix[j, i] = x;
    }

    void ClearingTheField()
    {
        for (int i = 0; i < thisInputWindows.GetLength(1); i++)
        {
            for (int j = 0; j < thisInputWindows.GetLength(0); j++)
            {              
               Destroy(thisInputWindows[j, i].gameObject);             
            }
            
        }
        
    }

    void CreateInputField(int X,int Y)
    {                                                              
        for (int i = 1; i <= Y; i++)
        {
            for (int j = 1; j <= X; j++)
            {
                GameObject thisInputWindow = Instantiate(infield, new Vector2(0, 0), Quaternion.identity);
                thisInputWindows[j - 1, i - 1] = thisInputWindow;

                thisInputWindow.GetComponent<RectTransform>().SetParent(gameObject.transform);
                thisInputWindow.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
                thisInputWindow.GetComponent<RectTransform>().anchorMax = new Vector2(j / 10f, 1 - (i / 10f));
                thisInputWindow.GetComponent<RectTransform>().anchorMin = new Vector2(j / 10f, 1 - (i / 10f));

            }
        }
    }

    void GetValue(int X, int Y)
    {

        for (int i = 0; i < Y; i++)
        {
            for (int j = 0; j < X; j++)
            {

                thisInputWindows[j,i].GetComponent<MatrixCell>().DataAcquisition(i, j);
            }
        }
    }
}
