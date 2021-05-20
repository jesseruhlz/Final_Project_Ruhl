using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : Interactable
{
    
    public GameObject dialogueBox;
    public Text dialogueText;
    public string dialogue;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space) && playerInRange)
        if (Input.GetButtonDown("Check") && playerInRange)
        {
            if(dialogueBox.activeInHierarchy)
            {
                dialogueBox.SetActive(false);
            }
            else
            {
                dialogueBox.SetActive(true);
                dialogueText.text = dialogue;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            contextOff.Raise();
            playerInRange = false;
            dialogueBox.SetActive(false);
        }

    }

}
