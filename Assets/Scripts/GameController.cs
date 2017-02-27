using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GameController : MonoBehaviour {



	private string playerSide; //"SNOW" or "SHOV"
	public Text[] buttonList;
	public Button[] snowButtonList;
	void Awake (){
		//TODO: Create countdown timer -"3, 2, 1"- for the start of the game
		//TODO: Create GameTimer for entire game duration (example: 5 minutes)
		playerSide = "SNOW";		
		SetGameControllerReferenceOnButtons();
		//TODO: inizialze values for numMoves
		//TODO: create variables to keep track of new turns
	}
	void SetGameControllerReferenceOnButtons (){
		for (int i = 0; i < buttonList.Length; i++){
		buttonList[i].GetComponentInParent< snow>().SetGameControllerReference(this);
		}
	}

	public string GetPlayerSide (){
		return playerSide;
	}

	public int GetNumberOfMoves(){
		//TODO: implement random number generator
		return 1;	
	}
	public void EndTurn (){
		if(String.Compare(playerSide, "SNOW") == 0){
			playerSide = "SHOV";		
		}	
		else{
			playerSide = "SNOW";		
		}
		//TODO: Check GameTimer, if reached limit, call GameOver() , else continue function 

		//TODO: Change later for efficiency. Don't loop over all 96 buttons MAYBE
		for(int i =0; i< snowButtonList.Length; i++){ //set all buttons as interactable.
			//TODO: Change buttons to interactable = true/false based on turn
			//      For example, if snow's turn, only green (different shades) are interractable)
			//if( ..... .... )
			//snowButtonList[i].interactable = true;
			//else 
			//snowButtonList[i].interactable = false;
		}
		
		//TODO: start TurnTimer (time limit for each player)




		//Debug.Log("EndTurn is not implemented!");

		
	}

	void GameOver(){
		
	}
}
