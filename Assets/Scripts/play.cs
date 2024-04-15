using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    public void Resetlevel(string advance)
    {
        SceneManager.LoadScene(advance);
    }
    public void Resetlevel1(string basic)
    {
        SceneManager.LoadScene(basic);
    }
    public void Resetlevel2(string intermediate)
    {
        SceneManager.LoadScene(intermediate);
    }
    public void Resetlevel3(string intermediateleft)
    {
        SceneManager.LoadScene(intermediateleft);
    }
    public void Resetlevel4(string advanceleft)
    {
        SceneManager.LoadScene(advanceleft);
    }
    public void Resetlevel5(string basicleft)
    {
        SceneManager.LoadScene(basicleft);
    }




}
