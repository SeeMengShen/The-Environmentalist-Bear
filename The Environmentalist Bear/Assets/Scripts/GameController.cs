using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    GameObject player;
    public GameObject goal;
    public bool hint;
    private int currentBlocked = 0;
    public TextMeshProUGUI current;
    public TextMeshProUGUI completeText;
    public string max;

    public bool checkHint()
    {
        if (hint)
        {
            return true;
        }
        return false;
    }

    public void checkCompleteMission()
    {
        if(current.text == max)
        {
            current.color = Color.green;
            completeText.gameObject.SetActive(true);
            goal.SetActive(true);
        }
    }

    public void updateCurrent()
    {
        currentBlocked++;
        current.text = currentBlocked.ToString();
    }
}
