using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quitting application");
            Application.Quit();
        }
    }
}
