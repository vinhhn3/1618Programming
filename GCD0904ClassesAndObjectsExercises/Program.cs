using System;
using System.Collections.Generic;
using System.Linq;

namespace GCD0904ClassesAndObjectsExercises
{
	class Program
	{
		static void Main(string[] args)
		{
			// Problem: Songs
			int numberOfSongs = int.Parse(Console.ReadLine());
			List<Song> songs = new List<Song>();
			string input = "";

			for (int i = 0; i < numberOfSongs; i++)
			{
				input = Console.ReadLine();
				string[] seperateInput = input.Split('_').ToArray();
				Song song = new Song(seperateInput[0], seperateInput[1], seperateInput[2]);
				songs.Add(song);
			}

			string typeList = Console.ReadLine();

			if (typeList.Equals("all"))
			{
				foreach (var item in songs)
				{
					Console.WriteLine(item.Name);
				}
			}
			else
			{
				foreach (var item in songs)
				{
					if (item.TypeList.Equals(typeList))
					{
						Console.WriteLine(item.Name);
					}
				}
			}

			Console.ReadLine();
		}
	}
}
