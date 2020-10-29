using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showInfo : MonoBehaviour
{
    public CanvasGroup ingradients;
    public CanvasGroup ingradientInfo1;
    public CanvasGroup ingradientInfo2;

    public Button ingradient1;
    public Button ingradient2;
    public Button close;
    public Button close2;
    void Start()
    {
        ingradient1.onClick.AddListener(Button1Down);
        ingradient2.onClick.AddListener(Button2Down);
        close.onClick.AddListener(CloseDown);
        close2.onClick.AddListener(CloseDown);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Button1Down()
    {
        Debug.Log("Button1Down down");
        ingradients.alpha = 0;
        ingradientInfo1.alpha = 1;
        ingradientInfo2.alpha = 0;
    }

    void Button2Down()
    {
        Debug.Log("Button2Down down");
        ingradients.alpha = 0;
        ingradientInfo1.alpha = 0;
        ingradientInfo2.alpha = 1;
    }

    void CloseDown()
    {
        Debug.Log("CloseDown down");
        ingradients.alpha = 1;
        ingradientInfo1.alpha = 0;
        ingradientInfo2.alpha = 0;
    }
}
