using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;

public class Door1 : MonoBehaviour
{
    public TextMeshProUGUI promptText;
    public string FirstDoor = "Passed to the next level";
    public string SecondDoor = "You Died";
    public string ThirdDoor = "Retreat";

    void Start()
    {
        promptText.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door1"))
        {
            promptText.text = FirstDoor;
            promptText.gameObject.SetActive(true);
        }

        if (other.CompareTag("Door2"))
        {
            promptText.text = SecondDoor;
            promptText.gameObject.SetActive(true);
        }

        if (other.CompareTag("Door3"))
        {
            promptText.text = ThirdDoor;
            promptText.gameObject.SetActive(true);
        }
    }
}
