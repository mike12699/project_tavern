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
    public Character Emotion1;
    public Character Emotion2;
    public Character Emotion3;
    public Character Emotion4;
    public Character Emotion5;
    public Character Emotion6;
    public Character Emotion7;
    public Character Emotion8;
    public Character Silhouette;
    public Character noSprite;
    public Character noArrowSprite;
    public Character protagonist1;
    public Character protagonist2;
    public Character protagonist3;
    public Character protagonist4;
    public Character protagonist5;
    public Character protagonist6;
    public Character protagonist7;
    public Character protagonist8;
    public Character protagonistNoSprite;
    public Character protagonistSilhouette;
    public Character protagonistNextChapter;
    public Line[] lines;
    public Question question;
    public Conversation nextConversation;
    public DrinkSystem drinkGame;
}
