using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dialoguemanager: MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public Message[] messages;
    public Actor[] actors;

    private int index;
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        // StartCoroutine(TypeLine());
     }

    private void StartDialogue()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == messages[index].message)
            {
              
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = messages[index].message;
            }
        }
    }

    private void NextLine()
    {
        throw new NotImplementedException();
    }

    [System.Serializable]
    public class Message
    {
        public int actorId;
        public string message;

    }
    [System.Serializable]
    public class Actor
    {
        public string name;
        public Sprite sprite;
    }


}






