using System;
using System.Collections.Generic;
using Game.Models;

namespace Game
{
  public class Program
  {
  public static Character player = new Character();
    public static void Main()
    {
      Console.WriteLine("The Oregon Trail!/n A Text-Based Adventure Game");
      Console.WriteLine("Would you like to start a new game? [YES] or [NO]");
      string response = Console.ReadLine();
      response = response.ToLower();
      if (response == "yes")
      {
        CreateCharacter();
      }
      else
      {
        Console.WriteLine("See ya never.");
      }
    }

    public static void CreateCharacter()
    {
      Console.WriteLine("Tomorrow, you will depart on your journey to Oregon!  Before you leave, there are a few things we need to take care of.\n First, What is your name?");
      string playerName = Console.ReadLine();
      player.SetName(playerName);
      Console.WriteLine("Hello! Your name is: " + player.Name + "\n Let the journey begin!");
      Journey();
    }

    public static void Journey()
    {
      string[] states = { "Missouri", "Kansas", "Nebraska", "Colorado", "Wyoming", "Idaho", "Washington", "Oregon" };
      Console.WriteLine("Welcome to " + states[0]);
      Console.WriteLine("----------------------");
      Locations.EncounterRiver();


    }


  }
}