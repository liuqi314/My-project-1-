using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next2 : MonoBehaviour
{
    public int Level3;

    public void GoNextScene()
    {
        SceneManager.LoadScene(Level3);
    }
}
