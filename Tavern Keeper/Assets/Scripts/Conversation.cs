using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Line
{
    public Character character;

    [TextArea(2, 5)]
    public string text;
}

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation")]
public class Conversation : ScriptableObject
{
    public Character speakerEmotion1;
    public Character speakerEmotion2;
    public Character speakerEmotion3;
    public Line[] lines;
    public Question question;
    public Conversation nextConversation;
}
