using UnityEngine;
using UnityEngine.UI;

public class NameText : MonoBehaviour
{
    public Text nameDisplay;

    void Start()
    {
        nameDisplay.text = GameManager.playerName;
    }
}
