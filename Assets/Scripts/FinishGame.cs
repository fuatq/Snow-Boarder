using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    
    public void RestartGame() {
        SceneManager.LoadScene(1);
    }

    public void QuitGame(){
        Application.Quit();
    }

}