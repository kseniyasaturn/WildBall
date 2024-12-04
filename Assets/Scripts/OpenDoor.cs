using UnityEngine;

 public class OpenDoor : MonoBehaviour
 {
    [SerializeField] private GameObject theDoor;
    
    private void Update()
    {
        if (Input.GetButtonDown("Open"))
        {
          theDoor.GetComponent<Animator>().enabled = true;
        }
    } 
 }



