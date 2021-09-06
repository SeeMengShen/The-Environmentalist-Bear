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
    public static bool[] completeLevel = new bool[3];
    public GameObject level2Button;
    public GameObject level3Button;
    public GameObject next1;
    public GameObject notComplete1;
    public GameObject next2;
    public GameObject notComplete2;
    public GameObject locked2Text;
    public GameObject locked3Text;
    private int currentDone = 0;
    public TextMeshProUGUI current;
    public TextMeshProUGUI completeText;
    public string max;
    public GameObject[] bonusStageObjects;
    public GameObject[] defaultMenu;

    void Start()
    {
        checkChangeSkin();
    }

    public void checkLevelProgress()
    {
        if (completeLevel[0])
        {
            locked2Text.SetActive(false);
            notComplete1.SetActive(false);
            level2Button.SetActive(true);
            next1.SetActive(true);

            if (completeLevel[1])
            {
                locked3Text.SetActive(false);
                notComplete2.SetActive(false);
                level3Button.SetActive(true);
                next2.SetActive(true);

                if (completeLevel[2])
                {
                    foreach (GameObject o in bonusStageObjects)
                    {
                        o.SetActive(true);
                    }

                    foreach (GameObject o in defaultMenu)
                    {
                        o.SetActive(false);
                    }
                }
            }
        }
    }

    public void completeLevelInt(int level)
    {
        if(level == 1)
        {
            completeLevel[0] = true;
        }
        else if(level == 2)
        {
            completeLevel[1] = true;
        }
        else if (level == 3)
        {
            completeLevel[2] = true;
        }
        else if(level == 4)
        {
            completeLevel[3] = true;
        }
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
