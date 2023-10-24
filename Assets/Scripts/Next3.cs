using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next3 : MonoBehaviour
{
    public int Level4;

    public void GoNextScene()
    {
        SceneManager.LoadScene(Level4);
    }
}
