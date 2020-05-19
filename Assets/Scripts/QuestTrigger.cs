using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    private QuestManager theQM;
    public int questNum;
    public bool startQuest;
    public bool endQuest;


    // Start is called before the first frame update
    void Start()
    {
        theQM = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (!theQM.questCompleted[questNum])
            {
                if (startQuest && !theQM.quests[questNum].gameObject.activeSelf)
                {
                    theQM.quests[questNum].gameObject.SetActive(true);
                    theQM.quests[questNum].StartQuest();
                }
                if (endQuest && theQM.quests[questNum].gameObject.activeSelf)
                {
                    theQM.quests[questNum].EndQuest();
                }
            }
        }
    }
}
