using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private Button pauseButton;

    private void Start()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnButtonClick()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
