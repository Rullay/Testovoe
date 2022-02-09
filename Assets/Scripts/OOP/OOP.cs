using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public  class OOP : MonoBehaviour
{
    private Square _square ;
    private Rectangle _rectangle;
    private Circle _circle;
    private Rhombus _rhombus;

    [SerializeField] private UnityEvent PaymentFigure;


    [SerializeField] private Text perimeterText;
    [SerializeField] private Text areaText;

    [SerializeField] private GameObject inputA;
    [SerializeField] private GameObject inputB;
    [SerializeField] private GameObject inputRadius;
    [SerializeField] private GameObject inputAngle;

    [SerializeField] private GameObject image_square;
    [SerializeField] private GameObject image_rectangle;
    [SerializeField] private GameObject image_circle;
    [SerializeField] private GameObject image_rhombus;


    private void Start()
    {
        PaymentFigure.AddListener(RectangleON);
    }

    void SquareON()
    {
        int.TryParse(inputA.GetComponent<InputField>().text, out int A);
        _square = new Square(A);
        perimeterText.text = "" + _square.PerimeterCalculation();
        areaText.text = "" + _square.AreaCalculation();
    }
    void RectangleON()
    {
        int.TryParse(inputA.GetComponent<InputField>().text, out int A);
        int.TryParse(inputB.GetComponent<InputField>().text, out int B);
        _rectangle = new Rectangle(A,B);
        perimeterText.text = "" + _rectangle.PerimeterCalculation();
        areaText.text = "" + _rectangle.AreaCalculation();
    }

    void CircleON()
    {
        int.TryParse(inputRadius.GetComponent<InputField>().text, out int Radius);
        _circle = new Circle(Radius);
        perimeterText.text = "" + _circle.PerimeterCalculation();
        areaText.text = "" + _circle.AreaCalculation();
    }

    void RhombusON()
    { 
        int.TryParse(inputA.GetComponent<InputField>().text, out int A);
        int.TryParse(inputAngle.GetComponent<InputField>().text, out int Angle);
        _rhombus = new Rhombus(A, Angle);
        perimeterText.text = "" + _rhombus.PerimeterCalculation();
        areaText.text = "" + _rhombus.AreaCalculation();
    }


    public void Payment()
    {
        PaymentFigure.Invoke();
    }


    public void SquareButton()
    {
        UIOff();
        image_square.SetActive(true);
        inputA.GetComponent<InputField>().interactable = true;
        PaymentFigure.RemoveAllListeners();  
        PaymentFigure.AddListener(SquareON);
    }

    public void RectangleButton()
    {
        UIOff();
        image_rectangle.SetActive(true);
        inputA.GetComponent<InputField>().interactable = true;
        inputB.GetComponent<InputField>().interactable = true;
        PaymentFigure.RemoveAllListeners();
        PaymentFigure.AddListener(RectangleON);
    }
    public void CircleButton()
    {
        UIOff();
        image_circle.SetActive(true);
        inputRadius.GetComponent<InputField>().interactable = true;
        PaymentFigure.RemoveAllListeners();
        PaymentFigure.AddListener(CircleON);
    }
    public void RhombusButton()
    {
        UIOff();
        image_rhombus.SetActive(true);
        inputA.GetComponent<InputField>().interactable = true;
        inputAngle.GetComponent<InputField>().interactable = true;
        PaymentFigure.RemoveAllListeners();
        PaymentFigure.AddListener(RhombusON);
    }

    void UIOff()
    {
        image_square.SetActive(false);
        image_rectangle.SetActive(false);
        image_circle.SetActive(false);
        image_rhombus.SetActive(false);

        inputA.GetComponent<InputField>().interactable = false;
        inputB.GetComponent<InputField>().interactable = false;
        inputAngle.GetComponent<InputField>().interactable = false;
        inputRadius.GetComponent<InputField>().interactable = false;

        inputA.GetComponent<InputField>().text = "";
        inputB.GetComponent<InputField>().text = "";
        inputAngle.GetComponent<InputField>().text = "";
        inputRadius.GetComponent<InputField>().text = "";
    }


}
