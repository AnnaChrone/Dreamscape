using UnityEngine;
using System.Collections.Generic;

public class CollectedItemsManager : MonoBehaviour
{
    public static CollectedItemsManager Instance;

    private HashSet<string> collectedItems = new HashSet<string>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        Debug.Log("CollectedItemsManager initialized. Instance ID: " + GetInstanceID());
    }

    public void MarkCollected(string id)
    {
        if (!collectedItems.Contains(id))
            collectedItems.Add(id);
    }

    public bool IsCollected(string id)
    {
        return collectedItems.Contains(id);
    }
}