using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    void Start()
    {
        string spawnName = SceneController.spawnPointName;
        if (string.IsNullOrEmpty(spawnName)) return;

        GameObject spawnPoint = GameObject.Find(spawnName);
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (spawnPoint != null && player != null)
        {
            player.transform.position = spawnPoint.transform.position;
        }
    }
}
