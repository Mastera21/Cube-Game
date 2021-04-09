using UnityEngine;

public class End : MonoBehaviour
{
    public GameManagerUpdate gameManager;
    public LevelScript level;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        level.Pass();

    }
}
