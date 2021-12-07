using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixController : MonoBehaviour
{
    public AudioSource[] OpenAndCloseMix;
    public GameObject confirmationPanel;
    public bool isActive;

    public void OpenConfirmationPanel()
    {
        if (isActive == false)
        {
            confirmationPanel.transform.gameObject.SetActive(true);
            isActive = true;
            //OpenAndCloseMix[0].Play();
        }
    }

    public void CloseConfirmationPanel()
    {
        if (isActive == true)
        {
            confirmationPanel.transform.gameObject.SetActive(false);
            isActive = false;
            //OpenAndCloseMix[1].Play();
        }
    }
}
