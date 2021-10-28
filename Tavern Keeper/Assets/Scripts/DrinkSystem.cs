using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrinkSystem : MonoBehaviour
{
    [SerializeField] Text limetxtDisplay;
    [SerializeField] Text orangetxtDisplay;
    [SerializeField] Text pineappletxtDisplay;
    [SerializeField] Text rumtxtDisplay;
    [SerializeField] Text vodkatxtDisplay;
    [SerializeField] Text somethingtxtDisplay;
    int limecounter = 0;
    int orangecounter = 0;
    int pineapplecounter = 0;
    int rumcounter = 0;
    int vodkacounter = 0;
    int somethingcounter = 0;
    //public DialogueDisplay resultConversation;

    void Start()
    {
        DisplayLimeNumber();
        DisplayOrangeNumber();
        DisplayPineappleNumber();
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

    public void IncreaseAndDisplayPineapple()
    {
        IncreasePineappleNumber();
        DisplayPineappleNumber();
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

    void IncreasePineappleNumber()
    {
        pineapplecounter++;
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

    void DisplayPineappleNumber()
    {
        pineappletxtDisplay.text = pineapplecounter.ToString();
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
        pineapplecounter = 0;
        rumcounter = 0;
        vodkacounter = 0;
        somethingcounter = 0;
        limetxtDisplay.text = "0";
        orangetxtDisplay.text = "0";
        pineappletxtDisplay.text = "0";
        rumtxtDisplay.text = "0";
        vodkatxtDisplay.text = "0";
        somethingtxtDisplay.text = "0";
    }
    public void LoadScene()
    {
        if (limetxtDisplay.text == "2" && pineappletxtDisplay.text == "3")
        {
            SceneManager.LoadScene("ShawGoodEnd");
        }
        else
        {
            SceneManager.LoadScene("ShawBadEnd");
        }
    }
}
