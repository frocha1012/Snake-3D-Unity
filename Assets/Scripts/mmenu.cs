using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mmenu : MonoBehaviour
{
    public void Normal()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //numeros é mais facil pra ordem das scenes que nomes
    }
    public void Hard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Instructions()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit the game!");
    }
}
