using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogueHolder : MonoBehaviour
{
    public string dialogue;
    private NPCDialogueManager dMan;
    public string[] dialogueLines;

    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<NPCDialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Check"))
        //{
        //    //dMan.ShowBox(dialogue);
        //    if (!dMan.dialogueActive)
        //    {
        //        dMan.dialogueLines = dialogueLines;
        //        dMan.currentLine = 0;
        //        dMan.ShowDialogue();
        //    }

        //    if (transform.parent.GetComponent<VillagerMovement>() != null)
        //    {
        //        transform.parent.GetComponent<VillagerMovement>().canMove = false;
        //    }
        //}
    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        //if(other.gameObject.name == "Player")
        if (other.CompareTag("Player"))
        {
            //if (Input.GetKeyUp(KeyCode.Space))
            if (Input.GetButtonDown("Check"))
            {
                //dMan.ShowBox(dialogue);
                if (!dMan.dialogueActive)
                {
                    dMan.dialogueLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }

                if (transform.parent.GetComponent<VillagerMovement>() != null)
                {
                    transform.parent.GetComponent<VillagerMovement>().canMove = false;
                }
            }
        }
    }
}
