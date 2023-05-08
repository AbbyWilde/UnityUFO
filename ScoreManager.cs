using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //text mesh pro name spavced added to access the librays for UI

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score; //keep our score value

    public TextMeshProUGUI scoreText; //Visual text element to be modified

    public void IncreaseScore(int amount) //this method when called increases the score by a predetermined amount set in score variable
    {
        score+= amount;
        UpdateScoreText();
    }

   public void DecreaseScore(int amount)//this method when called decreases the score by a predetermined amount set in score variable
    {
       score -= amount;
       UpdateScoreText(); 
    }
    public void UpdateScoreText()//updated the score in the HUD UI Text
    {
        scoreText.text = "Score: "+ score;
    }
}
