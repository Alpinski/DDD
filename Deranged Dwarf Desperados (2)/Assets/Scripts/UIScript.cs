using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public Image bulletOne, bulletTwo, bulletThree, bulletFour, 
				 bulletFive,bulletSix, bulletSeven, bulletEight;
    public Image healthFull, healthHalf, healthLow, healthEmpty;
    public Image uiHealthSource;
    public Text score;
    public Text accuracy;
    public Text bulletclip;

    public PlayerController player;

    private string scoreText;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + player.score;
        manageBulletUI();
    }

    void manageHealthUI()
    {
        switch(player.lives)
        {
            case 0:
                uiHealthSource = healthEmpty;
                break;
            case 1:
                uiHealthSource = healthLow;
                break;
            case 2:
                uiHealthSource = healthHalf;
                break;
            case 3:
                uiHealthSource = healthFull;
                break;
            default:
                break;
        }
    }

    void manageBulletUI()
    {
        switch (player.bulletClipCount)
        {
		case 0:
                bulletOne.enabled = false;
			    bulletTwo.enabled = false;
                bulletThree.enabled = false;
                bulletFour.enabled = false;
                bulletFive.enabled = false;
                bulletSix.enabled = false;
                bulletSeven.enabled = false;
                bulletEight.enabled = false;
                break;
            case 1:
                bulletOne.enabled = true;
                bulletTwo.enabled = false;
                bulletThree.enabled = false;
                bulletFour.enabled = false;
                bulletFive.enabled = false;
                bulletSix.enabled = false;
                bulletSeven.enabled = false;
                bulletEight.enabled = false;
                break;
            case 2:
                bulletOne.enabled = true;
                bulletTwo.enabled = true;
                bulletThree.enabled = false;
                bulletFour.enabled = false;
                bulletFive.enabled = false;
                bulletSix.enabled = false;
                bulletSeven.enabled = false;
                bulletEight.enabled = false;
                break;
            case 3:
                bulletOne.enabled = true;
                bulletTwo.enabled = true;
                bulletThree.enabled = true;
                bulletFour.enabled = false;
                bulletFive.enabled = false;
                bulletSix.enabled = false;
                bulletSeven.enabled = false;
                bulletEight.enabled = false;
                break;
            case 4:
                bulletOne.enabled = true;
                bulletTwo.enabled = true;
                bulletThree.enabled = true;
                bulletFour.enabled = true;
                bulletFive.enabled = false;
                bulletSix.enabled = false;
                bulletSeven.enabled = false;
                bulletEight.enabled = false;
                break;
            case 5:
                bulletOne.enabled = true;
                bulletTwo.enabled = true;
                bulletThree.enabled = true;
                bulletFour.enabled = true;
                bulletFive.enabled = true;
                bulletSix.enabled = false;
                bulletSeven.enabled = false;
                bulletEight.enabled = false;
                break;
            case 6:
                bulletOne.enabled = true;
                bulletTwo.enabled = true;
                bulletThree.enabled = true;
                bulletFour.enabled = true;
                bulletFive.enabled = true;
                bulletSix.enabled = true;
                bulletSeven.enabled = false;
                bulletEight.enabled = false;
                break;
            case 7:
                bulletOne.enabled = true;
                bulletTwo.enabled = true;
                bulletThree.enabled = true;
                bulletFour.enabled = true;
                bulletFive.enabled = true;
                bulletSix.enabled = true;
                bulletSeven.enabled = true;
                bulletEight.enabled = false;
                break;
            case 8:
                bulletOne.enabled = true;
                bulletTwo.enabled = true;
                bulletThree.enabled = true;
                bulletFour.enabled = true;
                bulletFive.enabled = true;
                bulletSix.enabled = true;
                bulletSeven.enabled = true;
                bulletEight.enabled = true;
                break;
            default:
                break;
        }
    }
}