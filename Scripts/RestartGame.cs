using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void ReStartGame(string level)
    {
        SceneManager.LoadScene(0);
    }
}
