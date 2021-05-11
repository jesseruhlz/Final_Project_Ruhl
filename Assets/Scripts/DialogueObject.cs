using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueObject : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI myText;

    public void Setup(string newDialogue)
    {
        myText.text = newDialogue;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
