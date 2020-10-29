using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class selectDishes : MonoBehaviour
{
    private Toggle dishes1;
    private Toggle dishes2;
    private Toggle dishes3;
    private Toggle dishes4;
    private Toggle dishes5;
    private Toggle dishes6;
    private Toggle dishes7;
    private Toggle dishes8;
    private Toggle dishes9;
    private Toggle dishes10;
    private Toggle dishes11;
    private Toggle dishes12;
    private Toggle dishes13;
    private Toggle dishes14;
    private Toggle dishes15;

    private Button startSelectButton;
    private Button nextButton1;
    private Button nextButton2;
    private Button previousButton1;
    private Button previousButton2;
    private Button confirmButton;
    private Button startButton;
    private Button changeButton;

    ArrayList activeDishes = new ArrayList();
    ArrayList dishesName = new ArrayList();
    ArrayList selectedDishes = new ArrayList();

    public GameObject welcomePage;
    public GameObject firstPage;
    public GameObject secondPage;
    public GameObject thirdPage;
    public GameObject confirmPage;

    public Text allDishes;
    void Start()
    {
        for (int i = 0; i < 15; i++) {
            activeDishes.Add(false);
        }

        dishesName.Add("Sweet and Sour Pork Tenderloin");
        dishesName.Add("Sweet and Sour Mandarin Fish");
        dishesName.Add("General Tso's chicken");
        dishesName.Add("Sweet and soup fish");
        dishesName.Add("Pineapple Flavored Sweet and Sour Pork");
        dishesName.Add("Ma Po Tofu");
        dishesName.Add("SiChuan Boiled Fish");
        dishesName.Add("Kung Pao Chicken");
        dishesName.Add("SiChuan Pork");
        dishesName.Add("Numbing Spicy Chicken");
        dishesName.Add("Steamed Vermicelli Rolls");
        dishesName.Add("Shrimp Dumplings");
        dishesName.Add("Steamed spareribs with glutinous rice");
        dishesName.Add("Braised Baby Cabbage in Broth");
        dishesName.Add("Bean curd with three fresh ingredients");

        dishes1 = GameObject.Find("dishes1").GetComponent<Toggle>();
        dishes1.onValueChanged.AddListener(Get1Down);
        dishes2 = GameObject.Find("dishes2").GetComponent<Toggle>();
        dishes2.onValueChanged.AddListener(Get2Down);
        dishes3 = GameObject.Find("dishes3").GetComponent<Toggle>();
        dishes3.onValueChanged.AddListener(Get3Down);
        dishes4 = GameObject.Find("dishes4").GetComponent<Toggle>();
        dishes4.onValueChanged.AddListener(Get4Down);
        dishes5 = GameObject.Find("dishes5").GetComponent<Toggle>();
        dishes5.onValueChanged.AddListener(Get5Down);
        dishes6 = GameObject.Find("dishes6").GetComponent<Toggle>();
        dishes6.onValueChanged.AddListener(Get6Down);
        dishes7 = GameObject.Find("dishes7").GetComponent<Toggle>();
        dishes7.onValueChanged.AddListener(Get7Down);
        dishes8 = GameObject.Find("dishes8").GetComponent<Toggle>();
        dishes8.onValueChanged.AddListener(Get8Down);
        dishes9 = GameObject.Find("dishes9").GetComponent<Toggle>();
        dishes9.onValueChanged.AddListener(Get9Down);
        dishes10 = GameObject.Find("dishes10").GetComponent<Toggle>();
        dishes10.onValueChanged.AddListener(Get10Down);
        dishes11 = GameObject.Find("dishes11").GetComponent<Toggle>();
        dishes11.onValueChanged.AddListener(Get11Down);
        dishes12 = GameObject.Find("dishes12").GetComponent<Toggle>();
        dishes12.onValueChanged.AddListener(Get12Down);
        dishes13 = GameObject.Find("dishes13").GetComponent<Toggle>();
        dishes13.onValueChanged.AddListener(Get13Down);
        dishes14 = GameObject.Find("dishes14").GetComponent<Toggle>();
        dishes14.onValueChanged.AddListener(Get14Down);
        dishes15 = GameObject.Find("dishes15").GetComponent<Toggle>();
        dishes15.onValueChanged.AddListener(Get15Down);

        startSelectButton = GameObject.Find("StartSelectButton").GetComponent<Button>();
        startSelectButton.onClick.AddListener(StartSelectButtonDown);
        nextButton1 = GameObject.Find("NextButton1").GetComponent<Button>();
        nextButton1.onClick.AddListener(NextButton1Down);
        nextButton2 = GameObject.Find("NextButton2").GetComponent<Button>();
        nextButton2.onClick.AddListener(NextButton2Down);
        previousButton1 = GameObject.Find("PreviousButton1").GetComponent<Button>();
        previousButton1.onClick.AddListener(PreviousButton1Down);
        previousButton2 = GameObject.Find("PreviousButton2").GetComponent<Button>();
        previousButton2.onClick.AddListener(PreviousButton2Down);
        confirmButton = GameObject.Find("ConfirmButton").GetComponent<Button>();
        confirmButton.onClick.AddListener(ConfirmButtonDown);
        startButton = GameObject.Find("StartButton").GetComponent<Button>();
        startButton.onClick.AddListener(StartButtonDown);
        changeButton = GameObject.Find("ChangeButton").GetComponent<Button>();
        changeButton.onClick.AddListener(ChangeButtonDown);
    }

    void Update()
    {
    }

    void Get1Down(bool value)
    {
        Debug.Log("dishes1 value change to" + value);
        if (value)
        {
            activeDishes[0] = true;
        }
        else {
            activeDishes[0] = false;
        } 
    }
    void Get2Down(bool value)
    {
        Debug.Log("dishes2 value change to" + value);
        if (value)
        {
            activeDishes[1] = true;
        }
        else
        {
            activeDishes[1] = false;
        }
    }
    void Get3Down(bool value)
    {
        Debug.Log("dishes3 value change to" + value);
        if (value)
        {
            activeDishes[2] = true;
        }
        else
        {
            activeDishes[2] = false;
        }
    }
    void Get4Down(bool value)
    {
        Debug.Log("dishes4 value change to" + value);
        if (value)
        {
            activeDishes[3] = true;
        }
        else
        {
            activeDishes[3] = false;
        }
    }
    void Get5Down(bool value)
    {
        Debug.Log("dishes5 value change to" + value);
        if (value)
        {
            activeDishes[4] = true;
        }
        else
        {
            activeDishes[4] = false;
        }
    }
    void Get6Down(bool value)
    {
        Debug.Log("dishes6 value change to" + value);
        if (value)
        {
            activeDishes[5] = true;
        }
        else
        {
            activeDishes[5] = false;
        }
    }
    void Get7Down(bool value)
    {
        Debug.Log("dishes7 value change to" + value);
        if (value)
        {
            activeDishes[6] = true;
        }
        else
        {
            activeDishes[6] = false;
        }
    }
    void Get8Down(bool value)
    {
        Debug.Log("dishes8 value change to" + value);
        if (value)
        {
            activeDishes[7] = true;
        }
        else
        {
            activeDishes[7] = false;
        }
    }
    void Get9Down(bool value)
    {
        Debug.Log("dishes9 value change to" + value);
        if (value)
        {
            activeDishes[8] = true;
        }
        else
        {
            activeDishes[8] = false;
        }
    }
    void Get10Down(bool value)
    {
        Debug.Log("dishes10 value change to" + value);
        if (value)
        {
            activeDishes[9] = true;
        }
        else
        {
            activeDishes[9] = false;
        }

    }
    void Get11Down(bool value)
    {
        Debug.Log("dishes11 value change to" + value);
        if (value)
        {
            activeDishes[10] = true;
        }
        else
        {
            activeDishes[10] = false;
        }

    }
    void Get12Down(bool value)
    {
        Debug.Log("dishes12 value change to" + value);
        if (value)
        {
            activeDishes[11] = true;
        }
        else
        {
            activeDishes[11] = false;
        }

    }
    void Get13Down(bool value)
    {
        Debug.Log("dishes13 value change to" + value);
        if (value)
        {
            activeDishes[12] = true;
        }
        else
        {
            activeDishes[12] = false;
        }

    }
    void Get14Down(bool value)
    {
        Debug.Log("dishes14 value change to" + value);
        if (value)
        {
            activeDishes[13] = true;
        }
        else
        {
            activeDishes[13] = false;
        }

    }
    void Get15Down(bool value)
    {
        Debug.Log("dishes15 value change to" + value);
        if (value)
        {
            activeDishes[14] = true;
        }
        else
        {
            activeDishes[14] = false;
        }

    }

    void StartSelectButtonDown()
    {
        Debug.Log("StartSelectButtonDown down");
        welcomePage.SetActive(false);
        firstPage.SetActive(true);
    }
    void NextButton1Down()
    {
        Debug.Log("NextButton1Down down");
        firstPage.SetActive(false);
        secondPage.SetActive(true);
        thirdPage.SetActive(false);
    }
    void NextButton2Down()
    {
        Debug.Log("NextButton2Down down");
        firstPage.SetActive(false);
        secondPage.SetActive(false);
        thirdPage.SetActive(true);
    }

    void PreviousButton1Down()
    {
        Debug.Log("PreviousButton1Down down");
        firstPage.SetActive(true);
        secondPage.SetActive(false);
        thirdPage.SetActive(false);
    }

    void PreviousButton2Down()
    {
        Debug.Log("PreviousButton2Down down");
        firstPage.SetActive(false);
        secondPage.SetActive(true);
        thirdPage.SetActive(false);
    }

    void ConfirmButtonDown()
    {
        Debug.Log("ConfirmButtonDown down");
        welcomePage.SetActive(false);
        firstPage.SetActive(false);
        secondPage.SetActive(false);
        thirdPage.SetActive(false);
        confirmPage.SetActive(true);
        for (int i = 0; i < 15; i++) {
            if (activeDishes[i].ToString() == true.ToString())
            {
                selectedDishes.Add(dishesName[i]);
            }
        }
        
        foreach (string str in selectedDishes) {
            allDishes.text += str + "\n";
        }
    }

    static public string[] passList;
    void StartButtonDown()
    {
        Debug.Log("StartButtonDown down");
        
        string[] array = (string[])selectedDishes.ToArray(typeof(string));
        passList = array;
        
        SceneManager.LoadScene("showMenu");
    }

    void ChangeButtonDown()
    {
        Debug.Log("ChangeButtonDown down");
        welcomePage.SetActive(false);
        firstPage.SetActive(true);
        secondPage.SetActive(false);
        thirdPage.SetActive(false);
        confirmPage.SetActive(false);
        selectedDishes.Clear();
        allDishes.text = "";
    }
}
