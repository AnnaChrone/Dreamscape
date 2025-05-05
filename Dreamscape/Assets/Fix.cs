using UnityEngine;

[ExecuteAlways] // Works in both edit and play modes
public class CameraLock : MonoBehaviour
{
    void Update()
    {
        Camera.main.orthographic = true;
        Camera.main.orthographicSize = 5; // Your desired size
        Camera.main.transform.position = new Vector3(0, 0, -10);
        Camera.main.transform.localScale = Vector3.one;
    }
}
