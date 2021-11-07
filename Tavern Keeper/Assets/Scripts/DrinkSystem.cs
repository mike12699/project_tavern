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
    [SerializeField] Text icetxtDisplay;
    [SerializeField] Text vodkatxtDisplay;
    [SerializeField] Text grapejuicetxtDisplay;
    int limecounter = 0;
    int orangecounter = 0;
    int sugarcounter = 0;
    int icecounter = 0;
    int vodkacounter = 0;
    int grapejuicecounter = 0;

    void Start()
    {
        DisplayLimeNumber();
        DisplayOrangeNumber();
        DisplaySugarNumber();
        DisplayIceNumber();
        DisplayVodkaNumber();
        DisplayGrapeJuiceNumber();
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

    public void IncreaseAndDisplayIce()
    {
        IncreaseIceNumber();
        DisplayIceNumber();
    }

    public void IncreaseAndDisplayVodka()
    {
        IncreaseVodkaNumber();
        DisplayVodkaNumber();
    }

    public void IncreaseAndDisplayGrapeJuice()
    {
        IncreaseGrapeJuiceNumber();
        DisplayGrapeJuiceNumber();
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

    void IncreaseIceNumber()
    {
        icecounter++;
    }

    void IncreaseVodkaNumber()
    {
        vodkacounter++;
    }

    void IncreaseGrapeJuiceNumber()
    {
        grapejuicecounter++;
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

    void DisplayIceNumber()
    {
        icetxtDisplay.text = icecounter.ToString();
    }

    void DisplayVodkaNumber()
    {
        vodkatxtDisplay.text = vodkacounter.ToString();
    }

    void DisplayGrapeJuiceNumber()
    {
        grapejuicetxtDisplay.text = grapejuicecounter.ToString();
    }

    public void ResetValues()
    {
        limecounter = 0;
        orangecounter = 0;
        sugarcounter = 0;
        icecounter = 0;
        vodkacounter = 0;
        grapejuicecounter = 0;
        limetxtDisplay.text = "0";
        orangetxtDisplay.text = "0";
        sugartxtDisplay.text = "0";
        icetxtDisplay.text = "0";
        vodkatxtDisplay.text = "0";
        grapejuicetxtDisplay.text = "0";
    }
    public void LoadShawScenes()
    {
        if (limetxtDisplay.text == "1" && sugartxtDisplay.text == "1" && grapejuicetxtDisplay.text == "1" && vodkatxtDisplay.text == "2" && icetxtDisplay.text == "1")
        {
            SceneManager.LoadScene("ShawGoodEnd");
        }
        else
        {
            SceneManager.LoadScene("ShawBadEnd");
        }
    }
}
