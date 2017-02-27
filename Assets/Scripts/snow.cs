using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class snow : MonoBehaviour {
  public Button button;

  
  private GameController gameController;

  //public Color color = new Color(1F, 1F, 1F, 0.9F);
	public Color snowColor = new Color(1F, 1F, 1F, 1F);
	public Color path1 = new Color(0.16F, 0.55F, 0.16F, 1F);
	public Color path2 = new Color(0.07F, 0.22F, 0.07F, 1F);
	public Color path3 = new Color(0F, 0F, 0F, 1F); //locked


  public Text buttonText;

  private int numMoves;
 // numMoves = gameController.GetNumberOfMoves();  
  public string playerSide; 
//	playerSide = gameController.GetPlayerSide(); 

  

	//WARNING: only compares RGB, not a
	public bool colorCompare(Color c1, Color c2){
		if( (int)(c1.b * 100) == (int)(c2.b *100) && (int)(c1.r * 100) == (int)(c2.r *100) && (int)(c1.g * 100) == (int)(c2.g *100)){
			return true;
		}
	else{
		return false;	
	}	
}





	public void SetGameControllerReference (GameController controller){
      gameController = controller;
  }



  public void SetSpace (){
 
		//buttonText.text = 
		//TODO: Change color based on previous color only NOT BASED ON TURN. EndTurn function takes care of that.	
		//Note: disabledColor is used to keep track of last color	
		ColorBlock cb = button.colors;
		if(colorCompare(cb.normalColor, snowColor)){
			if(colorCompare(cb.disabledColor, snowColor)){
				cb.normalColor = path1;			
			}
			else if(colorCompare(cb.disabledColor, path1)){
				cb.normalColor = path2;			
			}
			else if(colorCompare(cb.disabledColor, path2)){
				cb.normalColor = path3;
			}
		}		
		//else if(colorComapre(cp.normalColor, )
	
		cb.normalColor = snowColor;
    cb.highlightedColor = snowColor;
    button.colors = cb;
    buttonText.text = playerSide;
		button.interactable = false;
		numMoves = numMoves - 1;

		if(numMoves <= 0){
			gameController.EndTurn();
		}
  }

}
