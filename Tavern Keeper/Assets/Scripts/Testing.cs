using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is a test script to handle the dialogue system in-game
/// This script is temporary and will be refactored in a later build
/// </summary>

public class Testing : MonoBehaviour
{
    DialogueSystem dialogue;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = DialogueSystem.instance;
    }

    public string[] s = new string[]
    {
        "H-hello...:Amy",
        "This is my first time here at a bar.",
        "Honestly, this is actually a quite nice atmosphere.",
        "Um...",
        "I would like something sweet to drink please."
    };

    int index = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
            {
                if (index >= s.Length)
                {
                    return;
                }
                Say(s[index]);
                index++;
            }
        }
    }

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.Say(speech, speaker);
    }
}
