using UnityEngine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    public Text finalScoreDisplay;

    int finalScore;

    void Start()
    {
        finalScore = Score.CurrentScore;
        finalScoreDisplay.text = finalScore.ToString();
    }
}
