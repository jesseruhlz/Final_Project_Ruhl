using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonObject : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI myText;

    private int choiceValue;

    public void Setup(string newDialogue, int myChoice)
    {
        myText.text = newDialogue;
        choiceValue = myChoice;
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
