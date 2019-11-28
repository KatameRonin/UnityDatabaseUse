using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Acer : MonoBehaviour {

	public bool Display;
	DateTime check;
	public int c=0;
	public GameObject txt;
	public Text tx;

	// Use this for initialization
	IEnumerator Start () {
		txt.SetActive (false);
		Display = false;
		WWW ItemsData = new WWW ("http://localhost/Unity/Acer.php");
		yield return ItemsData;
		string str = ItemsData.text;
		tx.text = str;

	}

	void Update () {

		if (Display) {

			if (c == 0) {

				check = DateTime.Now;
				c++;
			}


			DateTime dtn=DateTime.Now;

			TimeSpan dif = dtn.Subtract (check);
			int d = Convert.ToInt32 (dif.TotalSeconds);
			//Debug.Log (d);
			if (d == 3) {
				txt.SetActive (true);

			}

		}

	}

	public void DisplayOn(){

		Display = true;
	}

	public void DisplayOff(){

		Display = false;
		txt.SetActive (false);
		c = 0;

	}


}



