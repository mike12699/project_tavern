using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixController : MonoBehaviour
{
    public GameObject confirmationPanel;
    public bool isActive;

    public void OpenConfirmationPanel()
    {
        if (isActive == false)
        {
            confirmationPanel.transform.gameObject.SetActive(true);
            isActive = true;
        }
    }

    public void CloseConfirmationPanel()
    {
        if (isActive == true)
        {
            confirmationPanel.transform.gameObject.SetActive(false);
            isActive = false;
        }
    }
}
