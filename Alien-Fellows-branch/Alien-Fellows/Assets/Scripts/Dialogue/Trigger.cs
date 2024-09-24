using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Dialogue Triggered");
        if (other.CompareTag("Player"))
        {
            TriggerDialogue();
        }
    }
}

