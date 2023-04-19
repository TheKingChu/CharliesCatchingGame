using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;

    public TMP_Text scoreText;
    int score = 0;
    [SerializeField] GameObject loseCanvas;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoreText.text = "Score: 0";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }

        if (other.gameObject.CompareTag("Bomb"))
        {
            StartCoroutine(KillPlayer());
        }
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    IEnumerator KillPlayer()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(loseCanvas);
    }
}
