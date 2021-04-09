using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    int levelsUnloked;

    public Button[] button;

    void Start()
    {
         levelsUnloked = PlayerPrefs.GetInt("levelsUnloked", 1);

        for (int i = 0; i < button.Length; i++)
        {
            button[i].interactable = false;
        }
        for (int i = 0; i < levelsUnloked; i++)
        {
            button[i].interactable = true;
        }
    }

    public void LoadlLevel(int currentLevel)
    {
        SceneManager.LoadScene(currentLevel);
    }
    
}
    