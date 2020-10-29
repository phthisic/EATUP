using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class changeLabel : MonoBehaviour
{
    public CanvasGroup label1;
    public CanvasGroup label2;
    public CanvasGroup label3;

    public Button btn1;
    public Button btn2;
    public Button btn3;

    public Button goback;
    public Button confirm;

    void Start()
    {
        btn1.onClick.AddListener(Show1);
        btn2.onClick.AddListener(Show2);
        btn3.onClick.AddListener(Show3);
        goback.onClick.AddListener(back);
        goback.onClick.AddListener(back);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Show1()
    {
        label1.alpha = (1);
        label2.alpha = (0);
        label3.alpha = (0);
    }
    void Show2()
    {
        label1.alpha = (0);
        label2.alpha = (1);
        label3.alpha = (0);
    }
    void Show3()
    {
        label1.alpha = (0);
        label2.alpha = (0);
        label3.alpha = (1);
    }

    void back()
    {
        SceneManager.LoadScene("showMenu");
    }
}
