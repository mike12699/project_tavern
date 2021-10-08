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

    public GameObject speakerEmotion1;
    public GameObject speakerEmotion2;
    public GameObject speakerEmotion3;

    private SpeakerUI speakerUIEmotion1;
    private SpeakerUI speakerUIEmotion2;
    private SpeakerUI speakerUIEmotion3;

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
        speakerUIEmotion1 = speakerEmotion1.GetComponent<SpeakerUI>();
        speakerUIEmotion2 = speakerEmotion2.GetComponent<SpeakerUI>();
        speakerUIEmotion3 = speakerEmotion3.GetComponent<SpeakerUI>();

        speakerUIEmotion1.Speaker = conversation.speakerEmotion1;
        speakerUIEmotion2.Speaker = conversation.speakerEmotion2;
        speakerUIEmotion3.Speaker = conversation.speakerEmotion3;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AdvanceLine();
        }
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
        /*if (activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
        }
        else
        {
            speakerUIEmotion1.Hide();
            speakerUIEmotion2.Hide();
            activeLineIndex = 0;
        }*/
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
        speakerUIEmotion1.Speaker = conversation.speakerEmotion1;
        speakerUIEmotion2.Speaker = conversation.speakerEmotion2;
        speakerUIEmotion3.Speaker = conversation.speakerEmotion3;
    }

    void AdvanceLine()
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

        if (speakerUIEmotion1.SpeakerIs(character))
        {
            SetDialogue(speakerUIEmotion1, speakerUIEmotion2, speakerUIEmotion3, line.text);
        }
        else if (speakerUIEmotion2.SpeakerIs(character))
        {
            SetDialogue(speakerUIEmotion2, speakerUIEmotion1, speakerUIEmotion3, line.text);
        }
        else
        {
            SetDialogue(speakerUIEmotion3, speakerUIEmotion2, speakerUIEmotion1, line.text);
        }

        activeLineIndex += 1;
    }

    void SetDialogue(SpeakerUI activeSpeakerUI, SpeakerUI inactiveSpeakerUI_1, SpeakerUI inactiveSpeakerUI_2, string text)
    {
        activeSpeakerUI.Dialogue = text;
        activeSpeakerUI.Show();
        inactiveSpeakerUI_1.Hide();
        inactiveSpeakerUI_2.Hide();
        activeSpeakerUI.Dialogue = "";
        StopAllCoroutines();
        StartCoroutine(TextCoroutine(text, activeSpeakerUI));
    }

    private IEnumerator TextCoroutine(string text, SpeakerUI speaker)
    {
        foreach (char character in text.ToCharArray())
        {
            speaker.Dialogue += character;
            // yield return new  WaitForSeconds(0.1f);
            yield return null;
        }
    }
}
