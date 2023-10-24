using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public int Level2;

    public void GoNextScene()
    {
        SceneManager.LoadScene(Level2);
    }





}
