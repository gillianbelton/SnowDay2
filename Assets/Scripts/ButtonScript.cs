using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	int count = 0;
	void Start () {

	}
  public void ButtonClick()
  {
       count++;
  }




	// Update is called once per frame
	void Update () {

    if (count == 8)
       {
             // TODO load next scene
             SceneManager.LoadScene("sc1");
       }

	}
}
