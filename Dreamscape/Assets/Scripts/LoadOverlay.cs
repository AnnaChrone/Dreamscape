using UnityEngine;

public class LoadOverlay : MonoBehaviour
{
    public static LoadOverlay instance;

    public float FriendValue = 50f;
    public float SanityValue = 50f;

    public FriendshipBar friendshipBar;
    public SanityBar sanityBar;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);  // keep overlay on top always
    }

    public void UpdateFriendValue(float value)
    {
        FriendValue = Mathf.Clamp(value, 0f, 100f);
    }

    public void UpdateSanityValue(float value)
    {
        SanityValue = Mathf.Clamp(value, 0f, 100f);
    }
}

