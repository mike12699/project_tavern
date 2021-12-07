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
    [SerializeField] Text cinnamontxtDisplay;
    [SerializeField] Text rumtxtDisplay;
    [SerializeField] Text gintxtDisplay;
    [SerializeField] Text lemontxtDisplay;
    [SerializeField] Text pineappletxtDisplay;
    [SerializeField] Text watertxtDisplay;
    [SerializeField] Text bourbontxtDisplay;
    [SerializeField] Text blackberrytxtDisplay;

    int limecounter = 0;
    int orangecounter = 0;
    int sugarcounter = 0;
    int icecounter = 0;
    int vodkacounter = 0;
    int grapejuicecounter = 0;
    int cinnamoncounter = 0;
    int rumcounter = 0;
    int gincounter = 0;
    int lemoncounter = 0;
    int pineapplecounter = 0;
    int watercounter = 0;
    int bourboncounter = 0;
    int blackberrycounter = 0;

    void Start()
    {
        DisplayLimeNumber();
        DisplayOrangeNumber();
        DisplaySugarNumber();
        DisplayIceNumber();
        DisplayVodkaNumber();
        DisplayGrapeJuiceNumber();
        DisplayCinnamonNumber();
        DisplayRumNumber();
        DisplayGinNumber();
        DisplayLemonNumber();
        DisplayPineappleNumber();
        DisplayWaterNumber();
        DisplayBourbonNumber();
        DisplayBlackberryNumber();
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

    public void IncreaseAndDisplayCinnamon()
    {
        IncreaseCinnamonNumber();
        DisplayCinnamonNumber();
    }

    public void IncreaseAndDisplayRum()
    {
        IncreaseRumNumber();
        DisplayRumNumber();
    }

    public void IncreaseAndDisplayGin()
    {
        IncreaseGinNumber();
        DisplayGinNumber();
    }

    public void IncreaseAndDisplayLemon()
    {
        IncreaseLemonNumber();
        DisplayLemonNumber();
    }

    public void IncreaseAndDisplayPineapple()
    {
        IncreasePineappleNumber();
        DisplayPineappleNumber();
    }

    public void IncreaseAndDisplayWater()
    {
        IncreaseWaterNumber();
        DisplayWaterNumber();
    }

    public void IncreaseAndDisplayBourbon()
    {
        IncreaseBourbonNumber();
        DisplayBourbonNumber();
    }

    public void IncreaseAndDisplayBlackberry()
    {
        IncreaseBlackberryNumber();
        DisplayBlackberryNumber();
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

    void IncreaseCinnamonNumber()
    {
        cinnamoncounter++;
    }

    void IncreaseRumNumber()
    {
        rumcounter++;
    }
    void IncreaseGinNumber()
    {
        gincounter++;
    }
    void IncreaseLemonNumber()
    {
        lemoncounter++;
    }
    void IncreasePineappleNumber()
    {
        pineapplecounter++;
    }
    void IncreaseWaterNumber()
    {
        watercounter++;
    }
    void IncreaseBourbonNumber()
    {
        bourboncounter++;
    }
    void IncreaseBlackberryNumber()
    {
        blackberrycounter++;
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

    void DisplayCinnamonNumber()
    {
        cinnamontxtDisplay.text = cinnamoncounter.ToString();
    }

    void DisplayRumNumber()
    {
        rumtxtDisplay.text = rumcounter.ToString();
    }

    void DisplayGinNumber()
    {
        gintxtDisplay.text = gincounter.ToString();
    }
    void DisplayLemonNumber()
    {
        lemontxtDisplay.text = lemoncounter.ToString();
    }
    void DisplayPineappleNumber()
    {
        pineappletxtDisplay.text = pineapplecounter.ToString();
    }
    void DisplayWaterNumber()
    {
        watertxtDisplay.text = watercounter.ToString();
    }
    void DisplayBourbonNumber()
    {
        bourbontxtDisplay.text = bourboncounter.ToString();
    }
    void DisplayBlackberryNumber()
    {
        blackberrytxtDisplay.text = blackberrycounter.ToString();
    }

    public void ResetValues()
    {
        limecounter = 0;
        orangecounter = 0;
        sugarcounter = 0;
        icecounter = 0;
        vodkacounter = 0;
        grapejuicecounter = 0;
        cinnamoncounter = 0;
        rumcounter = 0;
        gincounter = 0;
        lemoncounter = 0;
        pineapplecounter = 0;
        watercounter = 0;
        bourboncounter = 0;
        blackberrycounter = 0;
        limetxtDisplay.text = "0";
        orangetxtDisplay.text = "0";
        sugartxtDisplay.text = "0";
        icetxtDisplay.text = "0";
        vodkatxtDisplay.text = "0";
        grapejuicetxtDisplay.text = "0";
        cinnamontxtDisplay.text = "0";
        rumtxtDisplay.text = "0";
        gintxtDisplay.text = "0";
        lemontxtDisplay.text = "0";
        pineappletxtDisplay.text = "0";
        watertxtDisplay.text = "0";
        bourbontxtDisplay.text = "0";
        blackberrytxtDisplay.text = "0";
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

    public void LoadVampireScenes()
    {
        if (bourbontxtDisplay.text == "2" && cinnamontxtDisplay.text == "5" && sugartxtDisplay.text == "1" && watertxtDisplay.text == "1")
        {
            SceneManager.LoadScene("VampireGoodEnd");
        }
        else
        {
            SceneManager.LoadScene("VampireBadEnd");
        }
    }
}
