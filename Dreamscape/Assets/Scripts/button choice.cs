using System;
using System.Diagnostics;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class buttonchoice : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public DialogueTrigger DialogueTrigger;

    public void ButtonPressed()
    {

    }
    public void Choice1()
        {
        dialogueText.text = "I wake up to the sound of my alarm clock ringing, I feel like I just fell asleep. I have to get up and get ready for class, but I can't help but feel like I need more sleep.\r\n";
        print (dialogueText.text);
    }
     public void Choice2()
        {
            dialogueText.text = "I turn to my side and fall back asleep\r\n";
            print (dialogueText.text);
        }
    }

    