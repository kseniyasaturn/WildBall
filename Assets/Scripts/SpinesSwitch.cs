using System.Collections.Generic;
using UnityEngine;

public class SpinesSwitch : MonoBehaviour
{
    [SerializeField] private List<GameObject> deactivateObject = new List<GameObject>();

     private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < deactivateObject.Count; i++)
        {
            deactivateObject[i].SetActive(false);
        }
    }    
}
