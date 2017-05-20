using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GugudanController : MonoBehaviour {

	public Text mainText;

	public string question = "김연아 == 농구선수 ?";
	public bool answer = false;

	// Use this for initialization
	void Start () {

		mainText.text = question;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void QuizInput(bool inp){

		if (inp == answer) {
			mainText.text = "Right!";
		} else {
			mainText.text = "Wrong!";
		}

	}

	public void ForGugudan(){
		mainText.text = "";

		for (int i = 1; i <= 9; i++) {
			for (int j = 1; j <= 9; j++) {

				string str = i + " * " + j + " = " + (i * j) + " ";
				// 1 * 1 = 1

				mainText.text = mainText.text + str;

			}

			mainText.text = mainText.text + "\n";
		}
	}

	public void WhileGugudan(){
		mainText.text = "";

		int i = 1;
		int j = 1;

		while (i <= 9) {
			j = 1;
			while (j <= 9) {
				string str = i + " * " + j + " = " + (i * j) + " ";
				mainText.text = mainText.text + str;

				j = j + 1;
			}
			mainText.text = mainText.text + "\n";

			i = i + 1;
		}
	}
}
