using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrinkSystem : MonoBehaviour
{
    [SerializeField] Text txtDisplay;
    int counter = 0;
    //public DialogueDisplay resultConversation;

    void Start()
    {
        DisplayNumber();
    }

    public void IncreaseAndDisplay()
    {
        IncreaseNumber();
        DisplayNumber();
    }

    void IncreaseNumber()
    {
        counter++;
    }

    void DisplayNumber()
    {
        txtDisplay.text = counter.ToString();
    }
    public void LoadScene()
    {
        if (txtDisplay.text == "2")
        {
            SceneManager.LoadScene("ShawGoodEnd");
        }
        else
        {
            SceneManager.LoadScene("ShawBadEnd");
        }
    }
}
