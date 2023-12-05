using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next5 : MonoBehaviour
{

    public int Level6;

    public void GoNextScene()
    {
        SceneManager.LoadScene(Level6);
    }


}
