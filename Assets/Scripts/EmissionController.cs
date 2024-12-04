using System.Collections;
using UnityEngine;

public class EmissionController : MonoBehaviour
{
    [SerializeField] private ParticleSystem emission;

    private void Awake()
    {
        emission.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            emission.Play();
            Destroy(gameObject);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(emission);
    }
}
