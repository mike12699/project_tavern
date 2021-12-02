using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeBookController : MonoBehaviour
{
    public AudioSource[] OpenAndClose;
    public GameObject MindMelterPanel;
    public GameObject InsineratorPanel;
    public bool MindMelterisActive;
    public bool InsineratorisActive;
    public bool CloseMindMelterPanel;
    public bool CloseInsineratorPanel;

    public void OpenAndClosePanel()
    {
        if (MindMelterisActive == false)
        {
            InsineratorPanel.transform.gameObject.SetActive(false);
            MindMelterPanel.transform.gameObject.SetActive(true);
            //MindMelterisActive = true;
            OpenAndClose[0].Play();
        }
        else
        {
            MindMelterPanel.transform.gameObject.SetActive(false);
            //MindMelterisActive = false;
            OpenAndClose[1].Play();
        }
    }
    
    public void TurnToPageInsinerator()
    {
        if (InsineratorisActive == false)
        {
            MindMelterPanel.transform.gameObject.SetActive(false);
            InsineratorPanel.transform.gameObject.SetActive(true);
            //InsineratorisActive = true;
        }
        else
        {
            InsineratorPanel.transform.gameObject.SetActive(false);
            //InsineratorisActive = false;
        }
    }

    public void MindMelterPanelClose()
    {
        MindMelterPanel.transform.gameObject.SetActive(false);
    }

    public void InsineratorPanelClose()
    {
        InsineratorPanel.transform.gameObject.SetActive(false);
    }
}
