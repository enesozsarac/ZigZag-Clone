using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallPosition : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Buttons;

    public Button rstBtn, exitBtn;

    private int score = 0;
    public Text scoreText;

    
    private void Start()
    {
        rstBtn.onClick.AddListener(ResetBtn);
        Time.timeScale = 1;

        exitBtn.onClick.AddListener(ExitBtn);
    }

    private void Update()
    {
        if (Ball.transform.position.y <= -2)
        {
            Time.timeScale = 0;
            Buttons.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            score ++;
            scoreText.text = score.ToString();
        }
    }


    private void ResetBtn()
    {
        SceneManager.LoadScene(0);

    }

    private void ExitBtn()
    {
        Application.Quit();
    }

}
