using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showOneInfo : MonoBehaviour
{
    public CanvasGroup ingradients;
    public CanvasGroup ingradientInfo1;
    public Button ingradient1;
    public Button close;
    void Start()
    {
        ingradient1.onClick.AddListener(Button1Down);
        close.onClick.AddListener(CloseDown);
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
    }


    void CloseDown()
    {
        Debug.Log("CloseDown down");
        ingradients.alpha = 1;
        ingradientInfo1.alpha = 0;
    }
}
