//script for second sequence
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class BFirstTrigger : MonoBehaviour
{

	public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject TheMarker;
	public AudioSource line03;

	void OnTriggerEnter()
	{
		this.GetComponent<BoxCollider>().enabled = false;  
		ThePlayer.GetComponent<FirstPersonController>().enabled = false;
		StartCoroutine(ScenePlayer());
	}

	IEnumerator ScenePlayer()
	{
		TextBox.GetComponent<Text>().text = "Looks like there's a gun on that table!";
		line03.Play();
		yield return new WaitForSeconds(2.5f);
		TextBox.GetComponent<Text>().text = "";
		ThePlayer.GetComponent<FirstPersonController>().enabled = true;
		TheMarker.SetActive(true);

	}

}