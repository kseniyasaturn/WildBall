using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject firstScreen;
    private GameObject currentScreen;

    private void Start()
    {
        ChangeState(firstScreen);
    }

    public void ChangeState (GameObject nextScreen)
    {
        if(currentScreen != null)
        {
            currentScreen.SetActive(false);
        }
        nextScreen.SetActive(true);
        currentScreen = nextScreen;
    }
}
