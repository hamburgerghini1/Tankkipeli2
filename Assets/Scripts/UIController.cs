using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Text scoreText;
    public Text healthText;
    public Text livesText;

    public GameObject pauseMenu;
    public GameObject respawnScreen;
    public GameObject endScreen;
    public Text endScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            togglePause();
        }
    }

    public void SetScore(float score)
    {
        scoreText.text = "Score: " + score;
    }

    public void SetHealth(float current, float max)
    {
        healthText.text = "Health: " + current + "/" + max;
    }

    public void SetLives(int current, int max)
    {
        livesText.text = "Lives: " + current + "/" + max;
    }

    public void togglePause()
    {
        if(pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ShowRespawnScreen()
    {
        respawnScreen.SetActive(true);
    }

    public void HideRespawnScreen()
    {
        respawnScreen.SetActive(false);
    }

    public void ShowEndScreen()
    {
        endScore.text = "Your Score: " + score;
        endScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif        
    }
}
