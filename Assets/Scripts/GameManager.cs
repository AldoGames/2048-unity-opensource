using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private enum State{
		Loaded,
		WaitingForInput,
		CheckingMatching,
		GameOver
	}

	private State state;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {


	}
}
