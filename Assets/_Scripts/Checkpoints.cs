using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoints : MonoBehaviour
{
    bool isTimerOn = false;
    public float timeLeft;

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        isTimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                CountingDown(timeLeft);
                panel.SetActive(false);
            }
            else
            {
                timeLeft = 0;
                isTimerOn = false;
                panel.SetActive(true);
                Time.timeScale = 0;
                AudioListener.pause = true;
            }
        }
    }

    private void CountingDown(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
    }

    public void ContinueGameButton()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        panel.SetActive(false);
        isTimerOn = true;
        Debug.Log("somethiugn");
    }

    public void CheckoutButton()
    {
        SceneManager.LoadScene(0);
    }
}
