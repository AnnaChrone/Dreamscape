using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



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
        public GameObject button1, button2, button3,button4,button5,button6,button7,button8,button9,button10,button11,button12,button13,button14;





    private int index;
        private int actors;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        //textComponent.text = string.Empty;
        //code to hide the buttons at the start of the game
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button8.gameObject.SetActive(false);
            button9.gameObject.SetActive(false);
            button10.gameObject.SetActive(false);
            button11.gameObject.SetActive(false);
            button12.gameObject.SetActive(false);
            button13.gameObject.SetActive(false);
            button14.gameObject.SetActive(false);
            
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

            if(index == 16)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);
            
            }
            else
            {
                button1.gameObject.SetActive(false);
                button2.gameObject.SetActive(false);
            
            }

            if (index == 6)
            {
                button3.gameObject.SetActive(true);
            }
            else
            {
                button3.gameObject.SetActive(false);
            }

            if (index == 4)
            {
            button4.gameObject.SetActive(true);
            }
            else
            {
            button4.gameObject.SetActive(false);
            }

            if (index == 15)
            {
            button5.gameObject.SetActive(true);
            }
            else
            {
            button5.gameObject.SetActive(false);
            }

            if (index == 15)
            {
            button6.gameObject.SetActive(true);
            }
            else
            {
            button6.gameObject.SetActive(false);
            }

            if(index == 4)
            {
            button7.gameObject.SetActive(true);
            }
            else
            {
            button7.gameObject.SetActive(false);
            }

             if (index == 2)
            {
            button8.gameObject.SetActive(true);
            }
             else
            {
            button8.gameObject.SetActive(false);
            }

            if (index == 2)
            {
                button9.gameObject.SetActive(true);
            }
            else
            {
                button9.gameObject.SetActive(false);
            }

            if (index == 2)
            {
                button10.gameObject.SetActive(true);
            }
            else
            {
                button10.gameObject.SetActive(false);
            }

            if (index == 2)
            {
                button11.gameObject.SetActive(true);
            }
            else
            {
                button11.gameObject.SetActive(false);
            }

            if (index == 2)
            {
                button12.gameObject.SetActive(true);
            }
            else
            {
                button12.gameObject.SetActive(false);
            }

            if (index == 2)
            {
                button13.gameObject.SetActive(true);
            }
            else
            {
                button13.gameObject.SetActive(false);
            }

            if (index == 4)
            {
                button14.gameObject.SetActive(true);
            }
            else
            {
                button14.gameObject.SetActive(false);
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
                //elelmnt 0+1= elelmnt 1+1=element 2- switches btwn elements
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
                //gameObject.SetActive(false);
            }

         

    }
    }

