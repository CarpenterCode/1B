using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] Text scoreCount, finalScore, victoryScore;

    public int points = 0;

    private void Update()
    {
        scoreCount.text = points.ToString();
        finalScore.text = points.ToString();
        victoryScore.text = points.ToString();
    }

}
