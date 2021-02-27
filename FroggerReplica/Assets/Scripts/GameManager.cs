using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public static int lives = 1;
    public static string playerName;
    public static float carSpeed = 1;
    bool pause = false;

    public static GameManager instance;
    public Slider carSpeedSlider;
    public Dropdown livesSelect;

    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void NextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void SetCarSpeed()
    {
        carSpeed = carSpeedSlider.value;
    }

    public void SetLives()
    {
        lives = livesSelect.value + 1;
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void PauseToggle()
    {
        if (pause == false)
        {
            Time.timeScale = 0;
            pause = true;
        }
        else
        {
            Time.timeScale = 1;
            pause = false;
        }
    }
}
