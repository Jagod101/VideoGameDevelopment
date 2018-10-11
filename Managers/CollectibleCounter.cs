/*
 Name: Zach Jagoda
 ID: 2274813
 Email: jagod101@mail.chapman.edu
 Course:Unity Programming
 Midterm

 Purpose: Count the Collectibles and other things (activate and deactivate objects)			 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleCounter : MonoBehaviour {
	//An int to count our collectibles
	public int counter;

	public string textCount; 
	// to hold the int and information 
	public GameObject displayCount;

	//public GameObject displayHealth;

	public int countLimit;

    //Activate and Deactivate Objects
    public Camera finalCamera;
    public GameObject FPSController;
    public GameObject CollectedObjects;
    public GameObject RemainingTime;
    public moveDoor doorSlide;

    // Use this for initialization
    void Start () {
        finalCamera.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	//Creat a function we can call to increment the counter
	public void IncrementCount(){
		counter++;
		//display it on the screen with text itself
		displayCount.GetComponent<Text>().text = textCount + counter.ToString(); 

        if(counter == countLimit)
        {
            //Trigger Final Cutscene
            FPSController.gameObject.SetActive(false);
            finalCamera.gameObject.SetActive(true);
            CollectedObjects.gameObject.SetActive(false);
            RemainingTime.gameObject.SetActive(false);
            doorSlide.enabled = true;
        }
	}
    //Reset Counter if Player Runs out of Time
    public void resetCounter()
    {
        counter = 0;
        displayCount.GetComponent<Text>().text = textCount + 0;
    }
}
