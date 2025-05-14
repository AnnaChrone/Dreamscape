
using JetBrains.Annotations;
using UnityEngine;
using Ink.Runtime;

public class inkTestingScript : MonoBehaviour
{
    public TextAsset inkJSON;
    private Story story;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        story = new Story(inkJSON.text);    
        Debug.Log(story.Continue());


        // Update is called once per frame
        void Update()
        {

        }
    }

}



