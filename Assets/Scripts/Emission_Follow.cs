using UnityEngine;

public class EmissionFollow : MonoBehaviour
{
    [SerializeField] private Transform playerBall;

    private void Update()
    {
        transform.position = playerBall.position;
    }
}
