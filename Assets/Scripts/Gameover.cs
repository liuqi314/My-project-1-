using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{

    public Text pointsText;
   
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS ";
    }





}
