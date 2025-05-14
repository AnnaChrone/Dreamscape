using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



//public class DialogueTrigger : MonoBehaviour
//{
    //public Message[] messages;
    //public Actor[] actors;

    //[System.Serializable]
    /*public class Message
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


}*/





    public class Dialogue : MonoBehaviour
    {
        public TextMeshProUGUI textComponent;
        public TextMeshProUGUI nameTextComponent;
        public string[] lines;
        public string[] Actors;
        public float textSpeed;
        public GameObject button1, button2;
       



    private int index;
        private int actors;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
           
        //textComponent.text = string.Empty;
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            //textComponent.text = string.Empty;
            textComponent.text = string.Empty;
            nameTextComponent.text = string.Empty;
            StartDialogue();

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (textComponent.text == lines[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                }
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (nameTextComponent.text == Actors[actors])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    nameTextComponent.text = Actors[actors];
                }
            }

            if(index == 11)
        {
            button1.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
        }
        else
        {
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
        }
    }
        void StartDialogue()
        {
            index = 0;
            actors = 0;
            //StartCoroutine(TypeLine());
    }
      IEnumerator TypeLine()
       {
          foreach (char c in lines[index])
         {
            textComponent.text += c;
              yield return new WaitForSeconds(textSpeed);
           }


          foreach (char l in Actors[actors])
           {
               nameTextComponent.text += l;
               yield return new WaitForSeconds(textSpeed);
           }
    }



       public void NextLine()
        {
            if (index < lines.Length)
            {
                index++;
                //textComponent.text = string.Empty;
                //StartCoroutine(TypeLine());
        }
            else
            {
                //gameObject.SetActive(false);
            }

            if (actors < Actors.Length)
            {
            actors++;
                //nameTextComponent.text = string.Empty;
                //StartCoroutine(TypeLine());
        }
            else
            {
                gameObject.SetActive(false);
            }

            void choices()
        {
            //gameObject.SetActive(false);
        }

    }
    }

