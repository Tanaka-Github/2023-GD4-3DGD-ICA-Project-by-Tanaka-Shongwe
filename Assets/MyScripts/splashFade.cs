﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class splashFade : MonoBehaviour {

	public Image splashImage;
	public string loadlevel;

	IEnumerator Start(){

		Cursor.visible = false;
		

         splashImage.canvasRenderer.SetAlpha(0.0f);

		 FadeIn();
		 yield return new WaitForSeconds(2.5f);
		 FadeOut();
         yield return new WaitForSeconds(2.5f);
		 SceneManager.LoadScene(loadlevel);
	} 

	void FadeIn()
	{
     splashImage.CrossFadeAlpha(1.0f, 1.5f, false);



	}
	void FadeOut()
	{

     splashImage.CrossFadeAlpha(0.0f, 2.5f, false);

	}

	
}
