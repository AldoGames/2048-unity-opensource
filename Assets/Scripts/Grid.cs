using UnityEngine;
using System.Collections;

public class Grid {

	int size;
	int[][] cells;

	//Grid(size,previous)
	public Grid(int _size,int[][] _cells){
		size = _size;
		cells = _cells;
	}

	// Build a grid of the specified size
	public int[][] empty(){
		for (int x = 0; x < size; x++) {
			for (var y = 0; y < this.size; y++) {
				cells[x][y] = 0;// null not working
			}
		}
		return cells;
	}

	//public void fromState(state){ return cells;}

	public void randomAvailableCell(){

	}

	public void availableCells(){

	}

	//pubic void eachCell(callback)

	//public cellsAvailable(){ return }

	//public cellAvailable(){ return }




}
