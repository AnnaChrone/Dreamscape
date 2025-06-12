using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private Button[] choiceButtons;
    [SerializeField] private TMP_Text[] choiceTexts;
    public GameObject dialoguebox1;
    public GameObject dialoguebox2;
    public GameObject dialoguebox3;
    public GameObject dialoguebox4;
    public GameObject dialoguebox5;
    public GameObject dialoguebox6;
    public GameObject dialoguebox7;
    public GameObject dialoguebox8;
    public GameObject dialoguebox9;
    public GameObject dialoguebox10;
    public GameObject dialoguebox11;
    public GameObject dialoguebox12;
    public GameObject dialoguebox13;
    public GameObject dialoguebox14;
    public GameObject dialoguebox15;
    public GameObject dialoguebox16;
    public GameObject dialoguebox17;
    public GameObject dialoguebox18;
    public GameObject dialoguebox19;
    public GameObject dialoguebox20;
    public GameObject dialoguebox21;
    private int currentDialogueIndex = 0;

    // Sample dialogue structure
    /*private DialogueNode[] dialogueTree = new DialogueNode[]

    {
        new DialogueNode(
            "You approach a fork in the road. Which path do you take?",
            new string[] { "Awake", "Sleep In" },
            new int[] { 1, 2 } // Next node indices for each choice
        ),
        new DialogueNode(
            "You rise to the occassion",
            new string[] { "Continue" },
            new int[] { -1 } // -1 ends the dialogue
        ),
        new DialogueNode(
            "you sleep in and hear knocking at the door",
            new string[] { "Ignore it", "Answer" },
            new int[] { 3, 4 }


        )
        // Add more nodes as needed

    };*/

    public void choice0()
    {
        dialoguebox1.SetActive(false);
        dialoguebox2.SetActive(true);

    }


    //set.Active means when you press the button 
    public void choice1()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox2.SetActive(false);
        dialoguebox3.SetActive(true);

    }

    public void choice2()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox3.SetActive(false);
        dialoguebox4.SetActive(true);

    }

    public void choice3()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox4.SetActive(false);
        dialoguebox5.SetActive(true);

    }

    public void choice4()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox5.SetActive(false);
        dialoguebox6.SetActive(true);

    }
    public void choice5()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox6.SetActive(false);
        dialoguebox7.SetActive(true);

    }

    public void choice6()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox7.SetActive(false);
        dialoguebox8.SetActive(true);

    }

    public void choice7()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox8.SetActive(false);
        dialoguebox9.SetActive(true);

    }
    public void choice8()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox9.SetActive(false);
        dialoguebox10.SetActive(true);

    }
    public void choice9()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox10.SetActive(false);
        dialoguebox11.SetActive(true);

    }

    public void choice10()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox11.SetActive(false);
        dialoguebox12.SetActive(true);

    }
    public void choice11()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox12.SetActive(false);
        dialoguebox13.SetActive(true);

    }

    public void choice12()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox13.SetActive(false);
        dialoguebox14.SetActive(true);

    }

    public void choice13()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox14.SetActive(false);
        dialoguebox15.SetActive(true);

    }

    public void choice14()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox15.SetActive(false);
        dialoguebox16.SetActive(true);

    }

    public void choice15()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox16.SetActive(false);
        dialoguebox17.SetActive(true);

    }

    public void choice16()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox17.SetActive(false);
        dialoguebox18.SetActive(true);

    }

    public void choice17()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox18.SetActive(false);
        dialoguebox19.SetActive(true);

    }

    public void choice18()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox19.SetActive(false);
        dialoguebox20.SetActive(true);

    }

    public void choice19()
    //code for a button click 
    {
        //moving from the 2nd panel to the 3rd panel at the click of a button 
        dialoguebox20.SetActive(false);
        dialoguebox21.SetActive(true);

    }









    /*void Start()
    {
        // Hide all choice buttons initially
        foreach (Button button in choiceButtons)
        {
            button.gameObject.SetActive(false);
        }

        // Start the dialogue
        ShowDialogueNode(0);
    }

    void ShowDialogueNode(int nodeIndex)
    {
        if (nodeIndex < 0 || nodeIndex >= dialogueTree.Length)
        {
            EndDialogue();
            return;
        }

        DialogueNode currentNode = dialogueTree[nodeIndex];
        dialogueText.text = currentNode.dialogueText;

        // Activate and set up choice buttons
        for (int i = 0; i < currentNode.choices.Length; i++)
        {
            if (i < choiceButtons.Length)
            {
                choiceButtons[i].gameObject.SetActive(true);
                choiceTexts[i].text = currentNode.choices[i];

                // Store the next node index in the button's onClick event
                int nextNodeIndex = currentNode.nextNodeIndices[i];
                choiceButtons[i].onClick.RemoveAllListeners();
                choiceButtons[i].onClick.AddListener(() => ShowDialogueNode(nextNodeIndex));
            }
        }
    }

    void EndDialogue()
    {
        dialogueText.text = "The end.";
        foreach (Button button in choiceButtons)
        {
            button.gameObject.SetActive(false);
        }
    }
}*/

    // Helper class to store dialogue data
    [System.Serializable]
    public class DialogueNode
    {
        public string dialogueText;
        public string[] choices;
        public int[] nextNodeIndices;

        public DialogueNode(string text, string[] choices, int[] nextIndices)
        {
            this.dialogueText = text;
            this.choices = choices;
            this.nextNodeIndices = nextIndices;
        }
    }
}
