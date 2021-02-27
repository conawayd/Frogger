using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    public int lives = GameManager.lives;
    public Text livesDisplay;
    public GameObject gameManager;

    void Start()
    {
        livesDisplay.text = lives.ToString();
    }

    public void ReduceLife()
    {
        lives -= 1;
        livesDisplay.text = lives.ToString();

        if (lives < 1)
        {
            gameManager.GetComponent<GameManager>().NextScene();
        }
    }
}
