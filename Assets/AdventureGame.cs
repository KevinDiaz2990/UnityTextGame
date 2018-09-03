using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
    [SerializeField] Text textcomponent;
    [SerializeField] State startingState;
    
    
     

    State state;
	// Use this for initialization
	void Start () {
        state = startingState;
        textcomponent.text = state.GetStateStory();
       
	}
	
 
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        var nextStates = state.getNextStates(); //var will be interpreted as State[] by the C# compiler
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        textcomponent.text = state.GetStateStory();
    }
}
