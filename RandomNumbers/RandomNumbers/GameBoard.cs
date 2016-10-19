/*
 * Created by SharpDevelop.
 * User: Ale
 * Date: 17/10/2016
 * Time: 21:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RandomNumbers.Properties
{
	/// <summary>
	/// Description of GameBoard.
	/// </summary>
	public class GameBoard
	{
		int x {get;set;}
		int y {get;set;}
		
		Tile[,] Board = null;
			
		public GameBoard(int x, int y)
		{
			this.x = x;
			this.y = y;
			
			this.CleanBoard();
		}
		
		public void CleanBoard()
		{
			for(int i=0;i<x;i++)
			{
				for(int j=0;j<y;j++)
				{
					Board[i,j] = new Tile(Tile.TileType.Empty);
				}
			}
				
		}
	}
}
