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
    public GameObject protagonist1;
    public GameObject protagonist2;
    public GameObject protagonist3;
    public GameObject protagonist4;

    private SpeakerUI UIEmotion1;
    private SpeakerUI UIEmotion2;
    private SpeakerUI UIEmotion3;
    private SpeakerUI UIEmotion4;

    private SpeakerUI protagonistUI1;
    private SpeakerUI protagonistUI2;
    private SpeakerUI protagonistUI3;
    private SpeakerUI protagonistUI4;

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
        protagonistUI1 = protagonist1.GetComponent<SpeakerUI>();
        protagonistUI2 = protagonist2.GetComponent<SpeakerUI>();
        protagonistUI3 = protagonist3.GetComponent<SpeakerUI>();
        protagonistUI4 = protagonist4.GetComponent<SpeakerUI>();

        UIEmotion1.Speaker = conversation.Emotion1;
        UIEmotion2.Speaker = conversation.Emotion2;
        UIEmotion3.Speaker = conversation.Emotion3;
        UIEmotion4.Speaker = conversation.Emotion4;
        protagonistUI1.Speaker = conversation.protagonist1;
        protagonistUI2.Speaker = conversation.protagonist2;
        protagonistUI3.Speaker = conversation.protagonist3;
        protagonistUI4.Speaker = conversation.protagonist4;
    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AdvanceLine();
        }
    }*/

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
        protagonistUI1.Speaker = conversation.protagonist1;
        protagonistUI2.Speaker = conversation.protagonist2;
        protagonistUI3.Speaker = conversation.protagonist3;
        protagonistUI4.Speaker = conversation.protagonist4;
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
            SetDialogue(UIEmotion1, UIEmotion2, UIEmotion3, UIEmotion4, protagonistUI1, protagonistUI2, protagonistUI3, protagonistUI4, line.text);
        }
        else if (UIEmotion2.SpeakerIs(character))
        {
            SetDialogue(UIEmotion2, UIEmotion1, UIEmotion3, UIEmotion4, protagonistUI1, protagonistUI2, protagonistUI3, protagonistUI4, line.text);
        }
        else if (UIEmotion3.SpeakerIs(character))
        {
            SetDialogue(UIEmotion3, UIEmotion1, UIEmotion2, UIEmotion4, protagonistUI1, protagonistUI2, protagonistUI3, protagonistUI4, line.text);
        }
        else if (protagonistUI1.SpeakerIs(character))
        {
            SetDialogue(protagonistUI1, UIEmotion1, UIEmotion2, UIEmotion3, UIEmotion4, protagonistUI2, protagonistUI3, protagonistUI4, line.text);
        }
        else if (protagonistUI2.SpeakerIs(character))
        {
            SetDialogue(protagonistUI2, UIEmotion1, UIEmotion2, UIEmotion3, UIEmotion4, protagonistUI1, protagonistUI3, protagonistUI4, line.text);
        }
        else if (protagonistUI3.SpeakerIs(character))
        {
            SetDialogue(protagonistUI3, UIEmotion1, UIEmotion2, UIEmotion3, UIEmotion4, protagonistUI1, protagonistUI2, protagonistUI4, line.text);
        }
        else if (protagonistUI4.SpeakerIs(character))
        {
            SetDialogue(protagonistUI4, UIEmotion1, UIEmotion2, UIEmotion3, UIEmotion4, protagonistUI1, protagonistUI2, protagonistUI3, line.text);
        }
        else
        {
            SetDialogue(UIEmotion4, UIEmotion3, UIEmotion2, UIEmotion1, protagonistUI1, protagonistUI2, protagonistUI3, protagonistUI4, line.text);
        }

        activeLineIndex += 1;
    }

    void SetDialogue(SpeakerUI activeSpeakerUI, SpeakerUI inactiveSpeakerUI_1, SpeakerUI inactiveSpeakerUI_2, SpeakerUI inactiveSpeakerUI_3, SpeakerUI inactiveSpeakerUI_4, SpeakerUI inactiveSpeakerUI_5, SpeakerUI inactiveSpeakerUI_6, SpeakerUI inactiveSpeakerUI_7, string text)
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
