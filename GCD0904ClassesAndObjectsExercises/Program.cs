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

			// Problem: Students
			List<Student> students = new List<Student>();
			string inputStudent = Console.ReadLine();

			while (!inputStudent.Equals("end"))
			{
				string[] seperateInputStudent = inputStudent.Split(' ').ToArray();
				Student student = new Student(
					seperateInputStudent[0],
					seperateInputStudent[1],
					int.Parse(seperateInputStudent[2]),
					seperateInputStudent[3]
					);

				students.Add(student);
				inputStudent = Console.ReadLine();
			}

			string homeTown = Console.ReadLine();
			foreach (var item in students)
			{
				if (item.HomeTown.Equals(homeTown))
				{
					item.PrintInfo();
				}
			}

			// Box Stores
			List<Box> boxes = new List<Box>();
			string inputBox = Console.ReadLine();

			while (!inputBox.Equals("end"))
			{
				string[] seperateInputBox = inputBox.Split(' ').ToArray();

				Item item = new Item(seperateInputBox[1], double.Parse(seperateInputBox[3]));
				Box box = new Box(
					int.Parse(seperateInputBox[0]),
					item,
					int.Parse(seperateInputBox[2])
				);
				boxes.Add(box);

				inputBox = Console.ReadLine();
			}

			foreach (var item in boxes)
			{
				item.PrintInfo();
			}
			Console.ReadLine();
		}
	}
}
