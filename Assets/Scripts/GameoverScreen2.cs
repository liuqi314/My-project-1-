using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameoverScreen2 : MonoBehaviour
{
    [SerializeField] TMP_Text text;
   
    private TextMeshPro promptText;
    public TextMeshProUGUI pointsText;

    public void Setup(int score) {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Level3");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");

    }



}





