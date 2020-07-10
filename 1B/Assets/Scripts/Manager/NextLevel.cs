using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public int currentLevel = 1;

    [SerializeField] GameObject victoryScreen;
    [SerializeField] Text nextLevelCount, currentLevelCount;

    float _timer = 60;
    float _setTimer = 30f;
    float timerConvertor;

    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer < 0)
        {
            currentLevel++;
            _timer = _setTimer;
        }
        
        if (currentLevel > 11)
        {
            YouWon();
        }

        ShowTimer();
        ShowLevel();
    }


    void ShowTimer()
    {
        timerConvertor = _timer;
        timerConvertor = Mathf.Round(timerConvertor * 1) / 1;
        nextLevelCount.text = timerConvertor.ToString();
    }

    void ShowLevel()
    {
        currentLevelCount.text = currentLevel.ToString();
    }

    void YouWon()
    {
        victoryScreen.SetActive(true);
    }
}
