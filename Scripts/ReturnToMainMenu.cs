using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{

    public void BackToMainMenu(string level)
    {
        SceneManager.LoadScene(0);
    }

}
