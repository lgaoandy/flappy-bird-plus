using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int birdHealth;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("Decrease Health")]
    public void DecreaseHealth()
    {
        birdHealth -= 5;
        healthText.text = birdHealth.ToString();
    }
}
