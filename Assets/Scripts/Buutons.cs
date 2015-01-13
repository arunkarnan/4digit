using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Buutons : MonoBehaviour {
	//public Texture2D[] Buttons = new Texture2D[6];
	public static int littlecount = 0;
	public bool[] ButtonNumber = new bool[6];
	public Text[] Answer = new Text[4];
	public Text[] userInput = new Text[4];
	public Text[] MarkText = new Text[4];
	public Text winText;
	public Text[] PosText = new Text[4];

	public Text InputText;
	public bool[] isText1Active = new bool[4];

	public int count=0;
	public int[] AnswerNumber = new int[4];
	public int Limit;
	public int j=1;
	public int wincount=0;
	public bool Windecide;
	public int positionwin=0;
	public bool gameover;
	// Use this for initialization
	void Start () {
		RandomGenerator ();

	}
	
	// Update is called once per frame
	void Update () {
		updatebutton ();
		if (Windecide == true && gameover==false) {
						if (wincount == 4) {
								gameover=true;
								MarkAssignPosition();
								MarkAssignAll();
								winText.text = "Winner!!";	
						}
						else {
						gameover=true;
						MarkAssignPosition();
						MarkAssignAll();
						winText.text="Sorry Try Again";
						}
		}
		if (isText1Active [3] == true && Windecide==false) {
			predictwin();
			Windecide=true;
		}
	}


	public void MarkAssignAll(){
		for (int i=0; i<wincount; i++) {
			MarkText[i].text="y";
		}
		for (int ii=0; ii<positionwin && ii<4; ii++) {
		PosText[ii].text="n";	
		}
		}
	public void MarkAssignPosition(){
		for (int i=0; i<4; i++) {
			for(int ii=0;ii<4;ii++){
				if(AnswerNumber[i].ToString() == Answer[ii].text.ToString())
				++positionwin;
			}
		}
		Debug.Log (positionwin);
	}

	public void RandomGenerator(){
		for (int i=0; i<4; i++) {
			AnswerNumber[i]=UnityEngine.Random.Range(1,Limit+1);
			Debug.Log(AnswerNumber[i]);
		}
	}
	 
	int PickEmptyOne(){
		for ( j=0; j<4; j++) {
			if(isText1Active[j]==false){

				return j;

			}
		}
		return 5;
	}
	void predictwin(){
		if (isText1Active[3] == true) {
			for (int i = 0; i<4; i++) {
				if (Answer [i].text.ToString() == AnswerNumber [i].ToString ()) {
					wincount++;
				
				}
			}
			Debug.Log ("Win count is"+wincount);
		}
		
	}
	public void  Buttonenable(){
		if (littlecount < 4) {
						ButtonNumber [littlecount] = true;
						littlecount++;
				}
	
	}
	void updatebutton(){
		//GUI.backgroundColor = Color.clear;
		if (isText1Active [3] == false) {
								if (ButtonNumber[0] == true) {
								count = PickEmptyOne ();
								Answer [count].text = InputText.text;
								isText1Active [count] = true;
								Debug.Log (count);
								ButtonNumber[0] = false;
						}
								if (ButtonNumber[1] == true) {
								count = PickEmptyOne ();
								Answer [count].text = InputText.text;
								isText1Active [count] = true;
								Debug.Log (count);
								ButtonNumber[1] = false;
						}
								if (ButtonNumber[2] == true) {
								count = PickEmptyOne ();
								Answer [count].text = InputText.text;
								isText1Active [count] = true;
								Debug.Log (count);
								ButtonNumber[2] = false;
						}
								if (ButtonNumber[3] == true) {
								count = PickEmptyOne ();
								Answer [count].text = InputText.text;
								isText1Active [count] = true;
								Debug.Log (count);
								ButtonNumber[3] = false;
						}
								if (ButtonNumber[4] == true) {
								count = PickEmptyOne ();
								Answer [count].text = InputText.text;
								isText1Active [count] = true;
								Debug.Log (count);
								ButtonNumber[4] = false;
						}
								if (ButtonNumber[5] == true) {
								count = PickEmptyOne ();
								Answer [count].text = InputText.text;
								isText1Active [count] = true;
								Debug.Log (count);
								ButtonNumber[5] = false;
						}
		} 
					//	if (GUI.Button (new Rect (Screen.width - 100, Screen.height / 2 - 50, Screen.height / 7, Screen.height / 7), "Reset all")) {
					//	Application.LoadLevel (0);
					//	}
	}
}
