using UnityEngine;
using System.Collections;

public class LocalStorageManager {

	private string bestScoreKey = "bestScore";
	private string gameStateKey = "gameState";


	// Best score getters/setters

	public int getBestScore(){
		return PlayerPrefs.GetInt(bestScoreKey);
	}

	public void setBestScore(int score){
		PlayerPrefs.SetInt(bestScoreKey, score);
	}

	// Game state getters/setters and clearing
	// to do


}
