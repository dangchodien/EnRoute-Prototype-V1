using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonMasher : MonoBehaviour
{
    public Slider progressBar;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI gameWinText;
    public float decreaseRate = 1f;
    public float increaseAmount = 0.1f;
    public float winThreshold = 0.75f;
    private float timeRemain = 10f;
    private float startDelay = 1f;
<<<<<<< HEAD:Assets/Scripts/Minigame 3/ButtonMash.cs
    private bool _gameEnded = false;
    private bool _gameStarted = false; // Added variable to track game start
    private GameManager gameManager;
=======
    private bool gameEnded ;
    private GameManager gameManager;

>>>>>>> main:Assets/Scripts/Minigames/ButtonMasher.cs

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        gameOverText.enabled = false;
        gameWinText.enabled = false;
        gameManager = GameObject.FindObjectOfType<GameManager>();
        progressBar.value = 0.1f; // Ensure game over text is hidden initially
    }

    void Update()
    {
        if (gameEnded)
        {
            return; // Stop updating the game if it's over
        }

        if (!_gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            _gameStarted = true;
        }

        if (_gameStarted)
        {
            // Existing logic remains the same

            if (Input.GetKeyDown(KeyCode.Space))
            {
<<<<<<< HEAD:Assets/Scripts/Minigame 3/ButtonMash.cs
                float increaseFactor = Mathf.Exp(-progressBar.value * 2f);
                progressBar.value += increaseAmount * increaseFactor;
=======
                GameWin();
                gameManager.mini3Win = true;
>>>>>>> main:Assets/Scripts/Minigames/ButtonMasher.cs
            }

            progressBar.value -= decreaseRate * Time.deltaTime;
            timeRemain -= Time.deltaTime;
            startDelay -= Time.deltaTime;

            if (progressBar.value <= 0)
            {
                EndGame();
                gameManager.mini3Win = false;
            }

            if (timeRemain <= 0f)
            {
                if (progressBar.value >= winThreshold)
                {
                    GameWin();
                }
                else
                {
                    EndGame();
                }
            }
        }
    }

    void EndGame()
    {
<<<<<<< HEAD:Assets/Scripts/Minigame 3/ButtonMash.cs
        GameManager.mini3Win = false;
        _gameEnded = true;
=======
        gameEnded = true;
>>>>>>> main:Assets/Scripts/Minigames/ButtonMasher.cs
        gameOverText.enabled = true; // Show the game over text
        // Optionally, you can also disable the spacebar input here
    }

    void GameWin()
    {
<<<<<<< HEAD:Assets/Scripts/Minigame 3/ButtonMash.cs
        GameManager.mini3Win = true;
        _gameEnded = true;
=======
        gameEnded = true;
>>>>>>> main:Assets/Scripts/Minigames/ButtonMasher.cs
        gameWinText.enabled = true;
    }
}
