using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeBookController : MonoBehaviour
{
    public AudioSource[] OpenAndClose;
    public GameObject MindMelterPanel;
    public GameObject InsineratorPanel;
    public GameObject ZombiePanel;
    public GameObject RestorePanel;
    public bool MindMelterisActive;
    public bool InsineratorisActive;
    public bool ZombieisActive;
    public bool RestoreisActive;
    public bool CloseMindMelterPanel;
    public bool CloseInsineratorPanel;
    public bool CloseZombiePanel;
    public bool CloseRestorePanel;

    public void OpenAndClosePanel()
    {
        if (MindMelterisActive == false)
        {
            InsineratorPanel.transform.gameObject.SetActive(false);
            ZombiePanel.transform.gameObject.SetActive(false);
            RestorePanel.transform.gameObject.SetActive(false);
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
            ZombiePanel.transform.gameObject.SetActive(false);
            RestorePanel.transform.gameObject.SetActive(false);
            InsineratorPanel.transform.gameObject.SetActive(true);
            //InsineratorisActive = true;
        }
        else
        {
            InsineratorPanel.transform.gameObject.SetActive(false);
            //InsineratorisActive = false;
        }
    }

    public void TurnToPageZombie()
    {
        if (ZombieisActive == false)
        {
            MindMelterPanel.transform.gameObject.SetActive(false);
            InsineratorPanel.transform.gameObject.SetActive(false);
            RestorePanel.transform.gameObject.SetActive(false);
            ZombiePanel.transform.gameObject.SetActive(true);
        }
        else
        {
            ZombiePanel.transform.gameObject.SetActive(false);
        }
    }

    public void TurnToPageRestore()
    {
        if (RestoreisActive == false)
        {
            MindMelterPanel.transform.gameObject.SetActive(false);
            InsineratorPanel.transform.gameObject.SetActive(false);
            ZombiePanel.transform.gameObject.SetActive(false);
            RestorePanel.transform.gameObject.SetActive(true);
        }
        else
        {
            RestorePanel.transform.gameObject.SetActive(false);
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

    public void ZombiePanelClose()
    {
        ZombiePanel.transform.gameObject.SetActive(false);
    }

    public void RestorePanelClose()
    {
        RestorePanel.transform.gameObject.SetActive(false);
    }
}
