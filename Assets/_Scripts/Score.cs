using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    int score = 0;
    [SerializeField] GameObject loseCanvas;

    // Update is called once per frame
    void Update()
    {
        
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
            //Instantiate(loseCanvas);
        }
    }
}
