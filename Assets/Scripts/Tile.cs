using UnityEngine;
using System.Collections;

public class Tile {

	private int x;
	private int y;
	private int value;
	
	private Position previousPosition = new Position();
	private Position mergedFrom = new Position();

	public Tile(Position position,int _value){
		x = position.x;
		y = position.y;
		value = _value;

		previousPosition = null;
		mergedFrom = null;
	}

	public void savePosition(){

		previousPosition = Position(x, y);
	}

	public void updatePosition(Position position){

		x = position.x;
		y = position.y;
	}

	//to do
	public void serialize(){

	}

}
