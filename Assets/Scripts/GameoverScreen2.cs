using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;


public class GameoverScreen2 : MonoBehaviour
{
    [SerializeField] TMP_Text text;
   
    private TextMeshPro promptText;
    public TextMeshProUGUI pointsText;

    public void Setup(int score) {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }
}
