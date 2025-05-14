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


    private int currentDialogueIndex = 0;

    // Sample dialogue structure
    private DialogueNode[] dialogueTree = new DialogueNode[]

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

    };

    public void choice0()
    {
     dialoguebox1.SetActive(false);
        dialoguebox2.SetActive(true);
        
    }

    void Start()
    {
        dialoguebox2.SetActive(false);

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
}

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
