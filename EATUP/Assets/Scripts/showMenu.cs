using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class showMenu : MonoBehaviour
{
    public Text dishes1;
    public Text dishes2;
    public Text dishes3;
    public Text dishes4;
    public Text dishes5;
    public Text dishes6;
    public Text dishes7;
    public Text dishes8;
    public Text dishes9;

    public Button leftover1;
    public Button leftover2;
    void Start()
    {

        leftover1.onClick.AddListener(Comment1);
        leftover2.onClick.AddListener(Comment2);
        string[] dishesList = selectDishes.passList;
        foreach (string str in dishesList)
        {
            Debug.Log(str);
        }
        int size = dishesList.Length;
        int num1 = Random.Range(0, (size + 1) / 3);
        int num2 = Random.Range((size + 1) / 3, (size + 1) / 3 * 2);
        int num3 = Random.Range((size + 1) / 3 * 2, size + 1);
        int num4 = Random.Range(0, (size + 1) / 3);
        int num5 = Random.Range((size + 1) / 3, (size + 1) / 3 * 2);
        int num6 = Random.Range((size + 1) / 3 * 2, size + 1);
        int num7 = Random.Range(0, (size + 1) / 3);
        int num8 = Random.Range((size + 1) / 3, (size + 1) / 3 * 2);
        int num9 = Random.Range((size + 1) / 3 * 2, size + 1);

        dishes1.text = dishesList[num1];
        dishes2.text = dishesList[num2];
        dishes3.text = dishesList[num3];
        dishes4.text = dishesList[num4];
        dishes5.text = dishesList[num5];
        dishes6.text = dishesList[num6];
        dishes7.text = dishesList[num7];
        dishes8.text = dishesList[num8];
        dishes9.text = dishesList[num9];
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Comment1()
    {
        SceneManager.LoadScene(2);
    }

    void Comment2()
    {
        SceneManager.LoadScene(3);
    }

}
