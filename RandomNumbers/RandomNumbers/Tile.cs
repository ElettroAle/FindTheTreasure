/*
 * Created by SharpDevelop.
 * User: Ale
 * Date: 17/10/2016
 * Time: 21:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RandomNumbers
{
	/// <summary>
	/// Description of Tile.
	/// </summary>
	public class Tile
	{	
		public enum TileType
		{
			Straight = 1,
			TJunction = 2,
			CossJunction = 3,
			AngleJunction = 4,
			Flip = 5,
			Jolly = 6,
			Start1 = 7,
			Start2 = 8,
			Start3 = 9,
			Start4 = 10,
			Empty = 11,
			Wall = 12,
			Goal = 13,
		}
		public enum TileAngle
		{
			_0 = 0,
			_90 = 90,
			_180 = 180,
			_270 = 270,
		}
				
		TileAngle angle{get;set;}
		ConsoleColor color;		
		
		string Art0{get;set;}
		string Art90{get;set;}
		string Art180{get;set;}
		string Art270{get;set;}
					
		public Tile(int dice) : this((TileType)dice){}
		public Tile(TileType type) : this(type, TileAngle._0){}
		public Tile(TileType type, TileAngle angle)	
		{
			this.angle = angle;
			switch(type)
			{
				case TileType.Straight:
					color = ConsoleColor.Green;
					Art0 = "___";
					Art90 = " | ";
					Art180 = Art0;
					Art270 = Art90;
					break;
				case TileType.TJunction:
					color = ConsoleColor.Blue;
					Art0 = "_|_";
					Art90 = "-| ";
					Art180 = "-.-";
					Art270 = " |-";
					break;
				case TileType.AngleJunction:
					color = ConsoleColor.Red;
					Art0 = "_| ";
					Art90 = "-. ";
					Art180 = " .-";
					Art270 = " |_";
					break;
				case TileType.CossJunction:
					color = ConsoleColor.Cyan;
					Art0 = "-|-";
					Art90 = Art0;
					Art180 = Art0;
					Art270 = Art0;
					break;
				case TileType.Flip:
					color = ConsoleColor.Yellow;
					Art0 = "O";
					break;
				case TileType.Jolly:
					color = ConsoleColor.Magenta;
					Art0 = "J";
					Art90 = Art0;
					Art180 = Art0;
					Art270 = Art0;
					break;	
				case TileType.Start1:
					color = ConsoleColor.Green;
					Art0 = "1";
					Art90 = Art0;
					Art180 = Art0;
					Art270 = Art0;
					break;	
				case TileType.Start2:
					color = ConsoleColor.Green;
					Art0 = "2";
					Art90 = Art0;
					Art180 = Art0;
					Art270 = Art0;
					break;	
				case TileType.Start3:
					color = ConsoleColor.Green;
					Art0 = "3";
					Art90 = Art0;
					Art180 = Art0;
					Art270 = Art0;
					break;	
				case TileType.Start4:
					color = ConsoleColor.Green;
					Art0 = "4";
					Art90 = Art0;
					Art180 = Art0;
					Art270 = Art0;
					break;	
				case TileType.Empty:
					color = ConsoleColor.Green;
					Art0 = " ";
					
					break;	
				case TileType.Wall:
					color = ConsoleColor.Green;
					Art0 = "#";
					Art90 = Art0;
					Art180 = Art0;
					Art270 = Art0;
					break;	
				case TileType.Goal:
					color = ConsoleColor.Green;
					Art0 = "€";
					Art90 = Art0;
					Art180 = Art0;
					Art270 = Art0;
					break;	
			}
		}
		
		
					
		public void print()
		{
			Console.ForegroundColor = color;
			switch(angle)
			{
				case TileAngle._0:
					Console.Write(Art0);
					break;
				case TileAngle._90:
					Console.Write(Art90);
					break;
				case TileAngle._180:
					Console.Write(Art180);
					break;
				case TileAngle._270:
					Console.Write(Art270);
					break;					
			}
			Console.ResetColor();
		}
		public void printLine()
		{
			this.print();
			Console.Write("\n");
		}
	}
}
