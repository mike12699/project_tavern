using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSFX : MonoBehaviour
{
    public AudioSource[] dialogueAdvance;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogueAdvance[0].Play();
        }
    }
}
