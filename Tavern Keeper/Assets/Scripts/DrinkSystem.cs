using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrinkSystem : MonoBehaviour
{
    [SerializeField] Text limetxtDisplay;
    [SerializeField] Text orangetxtDisplay;
    [SerializeField] Text sugartxtDisplay;
    [SerializeField] Text rumtxtDisplay;
    [SerializeField] Text vodkatxtDisplay;
    [SerializeField] Text somethingtxtDisplay;
    int limecounter = 0;
    int orangecounter = 0;
    int sugarcounter = 0;
    int rumcounter = 0;
    int vodkacounter = 0;
    int somethingcounter = 0;
    //public DialogueDisplay resultConversation;

    void Start()
    {
        DisplayLimeNumber();
        DisplayOrangeNumber();
        DisplaySugarNumber();
        DisplayRumNumber();
        DisplayVodkaNumber();
        DisplaySomethingNumber();
    }

    public void IncreaseAndDisplayLime()
    {
        IncreaseLimeNumber();
        DisplayLimeNumber();
    }

    public void IncreaseAndDisplayOrange()
    {
        IncreaseOrangeNumber();
        DisplayOrangeNumber();
    }

    public void IncreaseAndDisplaySugar()
    {
        IncreaseSugarNumber();
        DisplaySugarNumber();
    }

    public void IncreaseAndDisplayRum()
    {
        IncreaseRumNumber();
        DisplayRumNumber();
    }

    public void IncreaseAndDisplayVodka()
    {
        IncreaseVodkaNumber();
        DisplayVodkaNumber();
    }

    public void IncreaseAndDisplaySomething()
    {
        IncreaseSomethingNumber();
        DisplaySomethingNumber();
    }

    void IncreaseLimeNumber()
    {
        limecounter++;
    }

    void IncreaseOrangeNumber()
    {
        orangecounter++;
    }

    void IncreaseSugarNumber()
    {
        sugarcounter++;
    }

    void IncreaseRumNumber()
    {
        rumcounter++;
    }

    void IncreaseVodkaNumber()
    {
        vodkacounter++;
    }

    void IncreaseSomethingNumber()
    {
        somethingcounter++;
    }

    void DisplayLimeNumber()
    {
        limetxtDisplay.text = limecounter.ToString();
    }

    void DisplayOrangeNumber()
    {
        orangetxtDisplay.text = orangecounter.ToString();
    }

    void DisplaySugarNumber()
    {
        sugartxtDisplay.text = sugarcounter.ToString();
    }

    void DisplayRumNumber()
    {
        rumtxtDisplay.text = rumcounter.ToString();
    }

    void DisplayVodkaNumber()
    {
        vodkatxtDisplay.text = vodkacounter.ToString();
    }

    void DisplaySomethingNumber()
    {
        somethingtxtDisplay.text = somethingcounter.ToString();
    }

    public void ResetValues()
    {
        limecounter = 0;
        orangecounter = 0;
        sugarcounter = 0;
        rumcounter = 0;
        vodkacounter = 0;
        somethingcounter = 0;
        limetxtDisplay.text = "0";
        orangetxtDisplay.text = "0";
        sugartxtDisplay.text = "0";
        rumtxtDisplay.text = "0";
        vodkatxtDisplay.text = "0";
        somethingtxtDisplay.text = "0";
    }
    public void LoadScene()
    {
        if (limetxtDisplay.text == "2" && sugartxtDisplay.text == "3")
        {
            SceneManager.LoadScene("ShawGoodEnd");
        }
        else
        {
            SceneManager.LoadScene("ShawBadEnd");
        }
    }
}
