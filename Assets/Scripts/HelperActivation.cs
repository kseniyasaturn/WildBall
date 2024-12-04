using System.Collections;
using UnityEngine;

public class HelperActivation : MonoBehaviour
{
    [SerializeField] private GameObject helperCanvas;

    private void Start()
    {
        helperCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            helperCanvas.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(helperCanvas);
        Destroy(gameObject);
    }
}
