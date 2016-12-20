﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestFPS : MonoBehaviour {

    private string mUnitNumbers;
    public InputField mInputField;

	// Use this for initialization
	void Awake () {
       // EventManager.GetInstance().AddEventListener("Prepare", StartBattle);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LoadSquad()
    {
        EventManager.GetInstance().SendEvent(EventId.LoadSquad, mInputField.text);
    }
    public void StartBattle()
    {
        EventManager.GetInstance().SendEvent(EventId.StartBattle);
    }
}