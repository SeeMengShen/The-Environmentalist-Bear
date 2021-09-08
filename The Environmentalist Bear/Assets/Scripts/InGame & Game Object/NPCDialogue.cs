using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextMeshProUGUI dialogue;
    public string sentence;
    public float typeSpeed;
    public bool talking = false;

    public void talk()
    {
        dialogueBox.SetActive(true);
        talking = true;
        StartCoroutine(displaySentence());
    }

    IEnumerator displaySentence()
    {
        dialogue.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogue.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }

        yield return new WaitForSeconds(5f);
        dialogueBox.SetActive(false);
        talking = false;
    }
}
