using UnityEngine;

public class Victrory : MonoBehaviour
{
    [SerializeField] private GameObject VictoryCanvas;

    private void Start()
    {
        VictoryCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            VictoryCanvas.SetActive(true);         
        }
    }
}
