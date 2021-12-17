using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeBookController : MonoBehaviour
{
    public GameObject AllDrinksPanel;
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
        if (AllDrinksPanel != null)
        {
            Animator animator = AllDrinksPanel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Open");
                animator.SetBool("Open", !isOpen);
            }
        }
    }

    public void TurnToPageMindMelter()
    {
        if (MindMelterisActive == false)
        {
            InsineratorPanel.transform.gameObject.SetActive(false);
            ZombiePanel.transform.gameObject.SetActive(false);
            RestorePanel.transform.gameObject.SetActive(false);
            MindMelterPanel.transform.gameObject.SetActive(true);
        }
        else
        {
            MindMelterPanel.transform.gameObject.SetActive(false);
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
        }
        else
        {
            InsineratorPanel.transform.gameObject.SetActive(false);
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
        if (AllDrinksPanel != null)
        {
            Animator animator = AllDrinksPanel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Open");
                animator.SetBool("Open", !isOpen);
            }
        }
    }

    public void InsineratorPanelClose()
    {
        if (AllDrinksPanel != null)
        {
            Animator animator = AllDrinksPanel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Open");
                animator.SetBool("Open", !isOpen);
            }
        }
    }

    public void ZombiePanelClose()
    {
        if (AllDrinksPanel != null)
        {
            Animator animator = AllDrinksPanel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Open");
                animator.SetBool("Open", !isOpen);
            }
        }
    }

    public void RestorePanelClose()
    {
        if (AllDrinksPanel != null)
        {
            Animator animator = AllDrinksPanel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Open");
                animator.SetBool("Open", !isOpen);
            }
        }
    }
}
