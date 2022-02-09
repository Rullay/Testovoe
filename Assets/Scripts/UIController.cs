using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIController : MonoBehaviour
{

    [SerializeField] private GameObject CanvasAlgorithms;
    [SerializeField] private GameObject CanvasArrays;
    [SerializeField] private GameObject CanvasHashing;
    [SerializeField] private GameObject CanvasOOP;
    [SerializeField] private GameObject CanvasMenu;


    void CloseAllCanvas()
    {
        CanvasAlgorithms.SetActive(false);
        CanvasArrays.SetActive(false);
        CanvasHashing.SetActive(false);
        CanvasOOP.SetActive(false);
        CanvasMenu.SetActive(false);
    }

    public void OnCanvasAlgorithms()
    {
        CloseAllCanvas();
        CanvasAlgorithms.SetActive(true);
    }
    public void OnCanvasArrays()
    {
        CloseAllCanvas();
        CanvasArrays.SetActive(true);
    }
    public void OnCanvasHashing()
    {
        CloseAllCanvas();
        CanvasHashing.SetActive(true);
    }
    public void OnCanvasOOPs()
    {
        CloseAllCanvas();
        CanvasOOP.SetActive(true);
    }

    public void ButtonBack()
    {
        CloseAllCanvas();
        CanvasMenu.SetActive(true);
    }

}
