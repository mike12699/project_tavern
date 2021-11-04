using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeBookController : MonoBehaviour
{
    public AudioSource[] OpenAndClose;
    public GameObject Panel;
    public bool isActive;

    public void OpenAndClosePanel()
    {
        if (isActive == false)
        {
            Panel.transform.gameObject.SetActive(true);
            isActive = true;
            OpenAndClose[0].Play();
        }
        else
        {
            Panel.transform.gameObject.SetActive(false);
            isActive = false;
            OpenAndClose[1].Play();
        }
    }
}
