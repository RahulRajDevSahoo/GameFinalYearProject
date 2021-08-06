using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class AOpening : MonoBehaviour
{

	public GameObject ThePlayer;
	public GameObject FadeScreenIn;
	public GameObject TextBox;
	public AudioSource line01;
	public AudioSource line02;

	void Start()
	{
		ThePlayer.GetComponent<FirstPersonController>().enabled = false; // disabling the first person controller when the game starts
		StartCoroutine(ScenePlayer());
	}

	IEnumerator ScenePlayer()
	{
		yield return new WaitForSeconds(1.5f);
		FadeScreenIn.SetActive(false);
		TextBox.GetComponent<Text>().text = "...Where am I?";
		line01.Play();
		yield return new WaitForSeconds(2);
		TextBox.GetComponent<Text>().text = "I got to get outta here";
		yield return new WaitForSeconds(0.5f);
		TextBox.GetComponent<Text>().text = "";
		line02.Play();
		yield return new WaitForSeconds(1.7f);
		TextBox.GetComponent<Text>().text = "";
		ThePlayer.GetComponent<FirstPersonController>().enabled = true;

	}

}
