using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSFX : MonoBehaviour
{
    public AudioSource[] dialogueAdvance;

    public void PlaySound()
    {
        dialogueAdvance[0].Play();
    }
}
