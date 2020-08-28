using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private bool DialogueTriggered = false;
    private Queue<string> sentences;
    private Text text;
    public Canvas canvas;
     

    //public void TriggerDialogue ()
    //{
    //    FindObjectOfType<DialogueManager>().startDialogue(dialogue);
    //}



    void Start()
    {
        sentences = new Queue<string>();
    }

    public void startDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        //DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);

        GameObject textGO = new GameObject();
        textGO.transform.parent = canvas.transform;
        textGO.AddComponent<Text>();

        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        text = textGO.GetComponent<Text>();
        text.font = arial;
        text.text = sentence;
        text.fontSize = 24;
        text.alignment = TextAnchor.MiddleCenter;

        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, -200, 0);
        rectTransform.sizeDelta = new Vector2(800, 200);

    }

    void EndDialogue()
    {
        DialogueTriggered = false;
        Debug.Log("End of conversation");
        Debug.Log(DialogueTriggered);
    }


    private void Update()
    {
        
        if (Input.GetKeyDown("f"))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;
            if (Physics.Raycast(rayOrigin, out hitinfo))
            {
                if ((hitinfo.collider.tag == "npc") && ! DialogueTriggered)
                {
                    startDialogue(dialogue);
                    DialogueTriggered = true;
                    Debug.Log(DialogueTriggered);
                }

                if ((hitinfo.collider.tag == "npc") && DialogueTriggered)
                {
                   Object.DestroyImmediate(text);
                   DisplayNextSentence();
                }

            }
        }

        
            
         
        //else
        //{
        //    DisplayNextSentence();
        //}


        //if (Input.GetKeyDown("f") && (DialogueTriggered = true))
        //{
        //    DisplayNextSentence();
        //}
    }

}
