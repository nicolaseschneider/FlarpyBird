using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Logic_Manager : MonoBehaviour
{
    public int playerScore;
    public Text uiText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore() {
        playerScore++;
        uiText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }
}
