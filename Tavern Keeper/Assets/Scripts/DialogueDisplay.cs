using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class QuestionEvent : UnityEvent<Question> { }

public class DialogueDisplay : MonoBehaviour
{
    public Conversation conversation;
    public QuestionEvent questionEvent;

    public GameObject Emotion1;
    public GameObject Emotion2;
    public GameObject Emotion3;
    public GameObject Emotion4;
    public GameObject Emotion5;
    public GameObject Silhouette;
    public GameObject noSprite;
    public GameObject protagonist1;
    public GameObject protagonist2;
    public GameObject protagonist3;
    public GameObject protagonist4;
    public GameObject protagonist5;
    public GameObject protagonistSilhouette;
    public GameObject protagonistNextChapter;

    private SpeakerUI UIEmotion1;
    private SpeakerUI UIEmotion2;
    private SpeakerUI UIEmotion3;
    private SpeakerUI UIEmotion4;
    private SpeakerUI UIEmotion5;
    private SpeakerUI UISilhouette;
    private SpeakerUI UInoSprite;

    private SpeakerUI protagonistUI1;
    private SpeakerUI protagonistUI2;
    private SpeakerUI protagonistUI3;
    private SpeakerUI protagonistUI4;
    private SpeakerUI protagonistUI5;
    private SpeakerUI protagonistUISilhouette;
    private SpeakerUI protagonistUINextChapter;

    private int activeLineIndex;
    private bool conversationStarted = false;

    public void ChangeConversation(Conversation nextConversation)
    {
        conversationStarted = false;
        conversation = nextConversation;
        AdvanceLine();
    }

    private void Start()
    {
        UIEmotion1 = Emotion1.GetComponent<SpeakerUI>();
        UIEmotion2 = Emotion2.GetComponent<SpeakerUI>();
        UIEmotion3 = Emotion3.GetComponent<SpeakerUI>();
        UIEmotion4 = Emotion4.GetComponent<SpeakerUI>();
        UIEmotion5 = Emotion5.GetComponent<SpeakerUI>();
        UISilhouette = Silhouette.GetComponent<SpeakerUI>();
        UInoSprite = noSprite.GetComponent<SpeakerUI>();
        protagonistUI1 = protagonist1.GetComponent<SpeakerUI>();
        protagonistUI2 = protagonist2.GetComponent<SpeakerUI>();
        protagonistUI3 = protagonist3.GetComponent<SpeakerUI>();
        protagonistUI4 = protagonist4.GetComponent<SpeakerUI>();
        protagonistUI5 = protagonist5.GetComponent<SpeakerUI>();
        protagonistUISilhouette = protagonistSilhouette.GetComponent<SpeakerUI>();
        protagonistUINextChapter = protagonistNextChapter.GetComponent<SpeakerUI>();

        UIEmotion1.Speaker = conversation.Emotion1;
        UIEmotion2.Speaker = conversation.Emotion2;
        UIEmotion3.Speaker = conversation.Emotion3;
        UIEmotion4.Speaker = conversation.Emotion4;
        UIEmotion5.Speaker = conversation.Emotion5;
        UISilhouette.Speaker = conversation.Silhouette;
        UInoSprite.Speaker = conversation.noSprite;
        protagonistUI1.Speaker = conversation.protagonist1;
        protagonistUI2.Speaker = conversation.protagonist2;
        protagonistUI3.Speaker = conversation.protagonist3;
        protagonistUI4.Speaker = conversation.protagonist4;
        protagonistUI5.Speaker = conversation.protagonist5;
        protagonistUISilhouette.Speaker = conversation.protagonistSilhouette;
        protagonistUINextChapter.Speaker = conversation.protagonistNextChapter;
    }

    void AdvanceConversation()
    {
        if (conversation.question != null)
        {
            questionEvent.Invoke(conversation.question);
        }
        else if (conversation.nextConversation != null)
        {
            ChangeConversation(conversation.nextConversation);
        }
        else
        {
            EndConversation();
        }
    }

    void EndConversation()
    {
        conversation = null;
        conversationStarted = false;
    }

    void Initialize()
    {
        conversationStarted = true;
        activeLineIndex = 0;
        UIEmotion1.Speaker = conversation.Emotion1;
        UIEmotion2.Speaker = conversation.Emotion2;
        UIEmotion3.Speaker = conversation.Emotion3;
        UIEmotion4.Speaker = conversation.Emotion4;
        UIEmotion5.Speaker = conversation.Emotion5;
        UISilhouette.Speaker = conversation.Silhouette;
        UInoSprite.Speaker = conversation.noSprite;
        protagonistUI1.Speaker = conversation.protagonist1;
        protagonistUI2.Speaker = conversation.protagonist2;
        protagonistUI3.Speaker = conversation.protagonist3;
        protagonistUI4.Speaker = conversation.protagonist4;
        protagonistUI5.Speaker = conversation.protagonist5;
        protagonistUISilhouette.Speaker = conversation.protagonistSilhouette;
        protagonistUINextChapter.Speaker = conversation.protagonistNextChapter;
    }

    public void AdvanceLine()
    {
        if (conversation == null)
        {
            return;
        }
        if (!conversationStarted)
        {
            Initialize();
        }
        if (activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
        }
        else
        {
            AdvanceConversation();
        }
    }

    void DisplayLine()
    {
        Line line = conversation.lines[activeLineIndex];
        Character character = line.character;

        if (UIEmotion1.SpeakerIs(character))
        {
            SetDialogue(
                UIEmotion1, 
                UIEmotion2, 
                UIEmotion3, 
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1,
                protagonistUI2,
                protagonistUI3,
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (UIEmotion2.SpeakerIs(character))
        {
            SetDialogue(
                UIEmotion2,
                UIEmotion1, 
                UIEmotion3, 
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1, 
                protagonistUI2, 
                protagonistUI3, 
                protagonistUI4, 
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (UIEmotion3.SpeakerIs(character))
        {
            SetDialogue(
                UIEmotion3,
                UIEmotion1,
                UIEmotion2,
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1, 
                protagonistUI2, 
                protagonistUI3, 
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (UIEmotion4.SpeakerIs(character))
        {
            SetDialogue(
                UIEmotion4,
                UIEmotion1,
                UIEmotion2,
                UIEmotion3,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1,
                protagonistUI2,
                protagonistUI3,
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (UIEmotion5.SpeakerIs(character))
        {
            SetDialogue(
                UIEmotion5,
                UIEmotion1,
                UIEmotion2,
                UIEmotion3,
                UIEmotion4,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1,
                protagonistUI2,
                protagonistUI3,
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (UISilhouette.SpeakerIs(character))
        {
            SetDialogue(
                UISilhouette,
                UIEmotion1,
                UIEmotion2,
                UIEmotion3,
                UIEmotion4,
                UIEmotion5,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1,
                protagonistUI2,
                protagonistUI3,
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (UInoSprite.SpeakerIs(character))
        {
            SetDialogue(
                UInoSprite,
                UIEmotion1,
                UIEmotion2,
                UIEmotion3,
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                protagonistUISilhouette,
                protagonistUI1,
                protagonistUI2,
                protagonistUI3,
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (protagonistUI1.SpeakerIs(character))
        {
            SetDialogue(
                protagonistUI1, 
                UIEmotion1, 
                UIEmotion2, 
                UIEmotion3, 
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI2, 
                protagonistUI3, 
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (protagonistUI2.SpeakerIs(character))
        {
            SetDialogue(
                protagonistUI2, 
                UIEmotion1, 
                UIEmotion2, 
                UIEmotion3, 
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1, 
                protagonistUI3, 
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (protagonistUI3.SpeakerIs(character))
        {
            SetDialogue(
                protagonistUI3,
                UIEmotion1, 
                UIEmotion2,
                UIEmotion3, 
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1, 
                protagonistUI2,
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (protagonistUI4.SpeakerIs(character))
        {
            SetDialogue(
                protagonistUI4, 
                UIEmotion1,
                UIEmotion2,
                UIEmotion3,
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1, 
                protagonistUI2,
                protagonistUI3,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (protagonistUI5.SpeakerIs(character))
        {
            SetDialogue(
                protagonistUI5,
                UIEmotion1,
                UIEmotion2,
                UIEmotion3,
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1,
                protagonistUI2,
                protagonistUI3,
                protagonistUI4,
                protagonistUINextChapter,
                line.text);
        }
        else if (protagonistUISilhouette.SpeakerIs(character))
        {
            SetDialogue(
                protagonistUISilhouette,
                UIEmotion1,
                UIEmotion2,
                UIEmotion3,
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUI1,
                protagonistUI2,
                protagonistUI3,
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }
        else if (protagonistUINextChapter.SpeakerIs(character))
        {
            SetDialogue(
                protagonistUINextChapter,
                UIEmotion1,
                UIEmotion2,
                UIEmotion3,
                UIEmotion4,
                UIEmotion5,
                UISilhouette,
                UInoSprite,
                protagonistUI1,
                protagonistUI2,
                protagonistUI3,
                protagonistUI4,
                protagonistUI5,
                protagonistUISilhouette,
                line.text);
        }
        else
        {
            SetDialogue(
                UISilhouette,
                UIEmotion5,
                UIEmotion4, 
                UIEmotion3,
                UIEmotion2,
                UIEmotion1,
                UInoSprite,
                protagonistUISilhouette,
                protagonistUI1, 
                protagonistUI2,
                protagonistUI3, 
                protagonistUI4,
                protagonistUI5,
                protagonistUINextChapter,
                line.text);
        }

        activeLineIndex += 1;
    }

    void SetDialogue(SpeakerUI activeSpeakerUI, SpeakerUI inactiveSpeakerUI_1, SpeakerUI inactiveSpeakerUI_2, SpeakerUI inactiveSpeakerUI_3, SpeakerUI inactiveSpeakerUI_4, SpeakerUI inactiveSpeakerUI_5, SpeakerUI inactiveSpeakerUI_6, SpeakerUI inactiveSpeakerUI_7, SpeakerUI inactiveSpeakerUI_8, SpeakerUI inactiveSpeakerUI_9, SpeakerUI inactiveSpeakerUI_10, SpeakerUI inactiveSpeakerUI_11, SpeakerUI inactiveSpeakerUI_12, SpeakerUI inactiveSpeakerUI_13, string text)
    {
        activeSpeakerUI.Dialogue = text;
        activeSpeakerUI.Show();
        inactiveSpeakerUI_1.Hide();
        inactiveSpeakerUI_2.Hide();
        inactiveSpeakerUI_3.Hide();
        inactiveSpeakerUI_4.Hide();
        inactiveSpeakerUI_5.Hide();
        inactiveSpeakerUI_6.Hide();
        inactiveSpeakerUI_7.Hide();
        inactiveSpeakerUI_8.Hide();
        inactiveSpeakerUI_9.Hide();
        inactiveSpeakerUI_10.Hide();
        inactiveSpeakerUI_11.Hide();
        inactiveSpeakerUI_12.Hide();
        inactiveSpeakerUI_13.Hide();
        activeSpeakerUI.Dialogue = "";
        StopAllCoroutines();
        StartCoroutine(TextCoroutine(text, activeSpeakerUI));
    }

    private IEnumerator TextCoroutine(string text, SpeakerUI speaker)
    {
        foreach (char character in text.ToCharArray())
        {
            speaker.Dialogue += character;
            yield return null;
        }
    }
}
