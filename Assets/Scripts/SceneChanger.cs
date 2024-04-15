using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void ChangeScene(string basic)
	{
		SceneManager.LoadScene(basic);
	}
	public void ChangeScene1(string intermediate)
	{
		SceneManager.LoadScene(intermediate);
	}
	public void ChangeScene2(string advance)
	{
		SceneManager.LoadScene(advance);
	}
	public void ChangeScene4(string home)
	{
		SceneManager.LoadScene(home);
	}
	public void ChangeScene5(string basicleft)
	{
		SceneManager.LoadScene(basicleft);
	}
	public void ChangeScene6(string intermediateleft)
	{
		SceneManager.LoadScene(intermediateleft);
	}
	public void ChangeScene7(string advanceleft)
	{
		SceneManager.LoadScene(advanceleft);
	}
	public void Exit()
	{
		Application.Quit();
	}
}
