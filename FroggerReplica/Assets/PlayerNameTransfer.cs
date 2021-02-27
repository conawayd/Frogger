using UnityEngine;
using UnityEngine.UI;

public class PlayerNameTransfer : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public Text textDisplay;

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = theName;

        GameManager.playerName = theName;
    }
}
