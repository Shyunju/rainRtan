using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    public static GameManager I;
    public Text scoreAText;
    public Text timeText;
    int totalScore =0;
    float limit = 60f;
    public GameObject panel;

    private void Awake()
    {
        I = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0, 0.5f);
        initGame();
    }

    // Update is called once per frame
    void Update()
    {
        limit -= Time.deltaTime;
        if (limit < 0)
        {
            Time.timeScale = 0.0f;
            limit = 0.0f;

            panel.SetActive(true);
        }
        timeText.text = limit.ToString("N2");
    }
    void makeRain()
    {
        Instantiate(rain);
    }

    public void addScore(int score)
    {
        totalScore += score;
        scoreAText.text = totalScore.ToString();
    }
    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }

    void initGame()
    {
        Time.timeScale = 1.0f;
        totalScore = 0;
        limit = 60f;
    }
}
