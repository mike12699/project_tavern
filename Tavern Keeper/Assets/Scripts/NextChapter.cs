using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Advance
{
    [TextArea(2, 5)]
    public string text;
    public Conversation conversation;
}

[CreateAssetMenu(fileName = "New Chapter", menuName = "Chapter")]
public class NextChapter : ScriptableObject
{
    [TextArea(2, 5)]
    public string text;
    public Advance advance;
}
