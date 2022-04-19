using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuiManager : MonoBehaviour
{
	private Animator anim;
    public void LoadNextScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		
	}

	public void LoadPrevScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

	}


	public void exitGame()
	{
		Application.Quit();
	}

	public void playAnim(Animator anim)
	{
		this.anim = anim;
		anim.SetBool("Anim", true);
		Invoke("pauseAnim", 0.1f);
	}

	private void pauseAnim()
	{
		anim.SetBool("Anim", false);
	}
}
