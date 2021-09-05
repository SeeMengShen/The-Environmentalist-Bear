using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public static bool skinChange;
    public Sprite grizzly;
    public Sprite panda;
    public GameObject goal;
    public bool hint;
    private int currentDone = 0;
    public TextMeshProUGUI current;
    public TextMeshProUGUI completeText;
    public string max;

    void Start()
    {
        checkChangeSkin();
    }

    public void changeSkin()
    {
        if (skinChange)
        {
            skinChange = false;
        }
        else
        {
            skinChange = true;
        }
    }

    public void checkChangeSkin()
    {
        if (skinChange)
        {
            player.GetComponent<SpriteRenderer>().sprite = panda;
            player.GetComponent<Animator>().SetBool("changeSkin", true);
        }
        else
        {
            player.GetComponent<SpriteRenderer>().sprite = grizzly;
            player.GetComponent<Animator>().SetBool("changeSkin", false);
        }
    }

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
        currentDone++;
        current.text = currentDone.ToString();
    }
}
