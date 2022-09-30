using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text scoreText;
    public Text healthText;
    public Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
