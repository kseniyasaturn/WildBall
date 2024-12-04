using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;

public class BallDeathEmission : MonoBehaviour
{ 
    [SerializeField] private ParticleSystem ballEmission;
    [SerializeField] private GameObject ball;

    private void Awake()
    {
        ballEmission.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballEmission.Play();
            Destroy(ball);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(ballEmission);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
