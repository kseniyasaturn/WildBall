using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsController : MonoBehaviour
{
    int levelUnlock;
    public Button[] buttons;

    private void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("levels", 1);

        for (int i = 0;i< buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i< levelUnlock; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
