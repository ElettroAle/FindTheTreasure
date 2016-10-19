/*
 * Created by SharpDevelop.
 * User: Ale
 * Date: 15/10/2016
 * Time: 12:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System; 

namespace RandomNumbers
{
	class Program
	{
		static bool quit = false; 
		
		public static void Main(string[] args)
		{
			int i;
			
			
			Random rnd = new Random();
			double[] perc = new double[6];
			for(i=0;i<perc.Length;i++){perc[i] = 0.0;}
			
			prinMainMenu();
			
			while(!quit)
			{
				string[] command = Console.ReadLine().ToUpper().Split(' ');
				switch(command[0])
				{
					case "S":
						Game();
						break;
					case "Q":
						quit = true;
						break;
					case "clear":
						Console.Clear();
						break;
					case "I":
						try
						{
							int throws = Convert.ToInt32(command[1]);
							for(i=0;i<throws;i++)
							{
								int result = ThrowSixFaceDiceWithPdf(rnd);
								perc[result-1] += result;
							}
							
							for(i=0;i<perc.Length;i++){
								perc[i] /= (i+1);
								perc[i] *= 100.0;
								perc[i] /= (double)throws;
								Console.WriteLine(i + "= " + perc[i] + "%");
							}
							for(i=0;i<perc.Length;i++){perc[i] = 0.0;}
						}
						catch
						{
							Console.WriteLine("Command Format Error!");
						}
						
						break;
					default:
						drawTile(rnd).printLine();
						break;
				}
			}
		}
		
		
		// impostare dentro a questa funzione la percentuale di tessere che si vuole avere.
		private static int ThrowSixFaceDiceWithPdf(Random random)
		{
			int dice = 0;
			int perc = random.Next(1, 101);   // creates a number between 1 and 6
			if(perc >= 1 && perc <= 25)        dice = 1;
			else if(perc >= 26 && perc <= 50)  dice = 2;
			else if(perc >= 51 && perc <= 75)  dice = 3;
			else if(perc >= 76 && perc <= 90)  dice = 4;
			else if(perc >= 90 && perc <= 95)  dice = 5;
			else if(perc >= 95 && perc <= 100) dice = 6;
			return dice;
		}
		
		private static Tile drawTile(Random rnd)
		{
			return new Tile(ThrowSixFaceDiceWithPdf(rnd));
		}
		
		private static void prinMainMenu()
		{
			Console.Clear();
			Console.WriteLine("FIND THE TREASURE OF THE PYRAMID!" +
			                  "\n__________________________________________________\n" +
			                  "S = start New Game, " +
			                  "Q = quit." +
			                  "\nI [n] = Draw n Tiles\n" +
			                  "Press any key to draw a tile\n");
		}
		
		private static void PrepareGameView()
		{
			Console.WriteLine(" ___________________________________________");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |$$$|   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			Console.WriteLine("|   |   |   |   |   |   |   |   |   |   |   |");
			Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|");
			
			
			
			// TODO: stampare la griglia di gioco
		}
		
		private static void Game()
		{
			Console.Clear();
			
			PrepareGameView();
			
			while(!quit)
			{
				string[] command = Console.ReadLine().ToUpper().Split(' ');
				switch(command[0])
				{
					case "Q":
						prinMainMenu();
						return;
						break;	
				}
				
			}
		}
	}
}