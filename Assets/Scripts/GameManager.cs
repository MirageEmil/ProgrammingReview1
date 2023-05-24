using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float playerLives = 3f;
    public TextMeshProUGUI playerLivesDisplay;
    private float playerScore = 0f;
    public TextMeshProUGUI playerScoreDisplay;

    public EnemyController enemyController;

    // Start is called before the first frame update
    void Start()
    {
        enemyController = FindObjectOfType<EnemyController>();

    }

    // Update is called once per frame
    void Update()
    {
        if(enemyController != null)
        {
            enemyController.speed = 5f;
        }
    }

    public void TakeDamage()
    {
        playerLives = playerLives--;
        LivesText();
    }

    public void EarnPoints()
    {
        playerScore = playerScore++;
        ScoreText();
    }

    public void ScoreText()
    {
        playerScoreDisplay.text = "Score: " + playerScore;
    }

    public void LivesText()
    {
        playerLivesDisplay.text = "Lives: " + playerLives;
    }

}
