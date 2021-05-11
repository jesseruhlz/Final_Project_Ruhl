using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchingDialogueController : MonoBehaviour
{
    [SerializeField] private GameObject branchingCanvas;
    [SerializeField] private GameObject dialoguePrefab;
    [SerializeField] private GameObject choicePrefab;
    [SerializeField] private TextAssetValue dialogueValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableCanvas()
    {
        branchingCanvas.SetActive(true);
    }
}
