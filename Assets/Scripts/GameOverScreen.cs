using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }
}
