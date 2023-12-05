using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next4 : MonoBehaviour
{
    public int Level5;

    public void GoNextScene()
    {
        SceneManager.LoadScene(Level5);
    }


}
