using System;
using System.Collections.Generic;
using System.Threading;
using roshambo.Models;

namespace roshambo
{
  class Program
  {
    static void Main(string[] args)
    {

      bool playing = true;
      Console.Clear();
      while (playing)
      {
        Thread s = new Thread(song);
        s.Start();
        Random rnd = new Random();
        string[] ComputerChoice = { "rock", "paper", "scissors" };
        int cChoice = rnd.Next(ComputerChoice.Length);
        Console.WriteLine("rock, paper or scissors?");
        string UserResponse = Console.ReadLine();
        if (UserResponse != "rock" & UserResponse != "paper" & UserResponse != "scissors")
        {
          Console.WriteLine("I dont remember giving you that option!");
          return;
        }
        Game grs = new Game(UserResponse, ComputerChoice[cChoice]);
        string results = grs.GameResults();
        Console.WriteLine("Computer: {0}", ComputerChoice[cChoice]);
        Console.WriteLine("Game results: {0}", results);
        Console.WriteLine("Play again? (Y/N)");
        string endGame = Console.ReadLine();
        if (endGame.ToUpper() != "Y")
        {
          playing = false;
        }

      }

    }
    static void song()
    {
      Console.Beep(659, 125);
      Console.Beep(659, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(167);
      Console.Beep(523, 125);
      Console.Beep(659, 125);
      Thread.Sleep(125);
      Console.Beep(784, 125);
      Thread.Sleep(375);
      Console.Beep(392, 125);
      Thread.Sleep(375);
      Console.Beep(523, 125);
      Thread.Sleep(250);
      Console.Beep(392, 125);
      Thread.Sleep(250);
      Console.Beep(330, 125);
      Thread.Sleep(250);
      Console.Beep(440, 125);
      Thread.Sleep(125);
      Console.Beep(494, 125);
      Thread.Sleep(125);
      Console.Beep(466, 125);
      Thread.Sleep(42);
      Console.Beep(440, 125);
      Thread.Sleep(125);
      Console.Beep(392, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(125);
      Console.Beep(784, 125);
      Thread.Sleep(125);
      Console.Beep(880, 125);
      Thread.Sleep(125);
      Console.Beep(698, 125);
      Console.Beep(784, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(125);
      Console.Beep(523, 125);
      Thread.Sleep(125);
      Console.Beep(587, 125);
      Console.Beep(494, 125);
      Thread.Sleep(125);
      Console.Beep(523, 125);
      Thread.Sleep(250);
      Console.Beep(392, 125);
      Thread.Sleep(250);
      Console.Beep(330, 125);
      Thread.Sleep(250);
      Console.Beep(440, 125);
      Thread.Sleep(125);
      Console.Beep(494, 125);
      Thread.Sleep(125);
      Console.Beep(466, 125);
      Thread.Sleep(42);
      Console.Beep(440, 125);
      Thread.Sleep(125);
      Console.Beep(392, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(125);
      Console.Beep(784, 125);
      Thread.Sleep(125);
      Console.Beep(880, 125);
      Thread.Sleep(125);
      Console.Beep(698, 125);
      Console.Beep(784, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(125);
      Console.Beep(523, 125);
      Thread.Sleep(125);
      Console.Beep(587, 125);
      Console.Beep(494, 125);
      Thread.Sleep(375);
      Console.Beep(784, 125);
      Console.Beep(740, 125);
      Console.Beep(698, 125);
      Thread.Sleep(42);
      Console.Beep(622, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(167);
      Console.Beep(415, 125);
      Console.Beep(440, 125);
      Console.Beep(523, 125);
      Thread.Sleep(125);
      Console.Beep(440, 125);
      Console.Beep(523, 125);
      Console.Beep(587, 125);
      Thread.Sleep(250);
      Console.Beep(784, 125);
      Console.Beep(740, 125);
      Console.Beep(698, 125);
      Thread.Sleep(42);
      Console.Beep(622, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(167);
      Console.Beep(698, 125);
      Thread.Sleep(125);
      Console.Beep(698, 125);
      Console.Beep(698, 125);
      Thread.Sleep(625);
      Console.Beep(784, 125);
      Console.Beep(740, 125);
      Console.Beep(698, 125);
      Thread.Sleep(42);
      Console.Beep(622, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(167);
      Console.Beep(415, 125);
      Console.Beep(440, 125);
      Console.Beep(523, 125);
      Thread.Sleep(125);
      Console.Beep(440, 125);
      Console.Beep(523, 125);
      Console.Beep(587, 125);
      Thread.Sleep(250);
      Console.Beep(622, 125);
      Thread.Sleep(250);
      Console.Beep(587, 125);
      Thread.Sleep(250);
      Console.Beep(523, 125);
      Thread.Sleep(1125);
      Console.Beep(784, 125);
      Console.Beep(740, 125);
      Console.Beep(698, 125);
      Thread.Sleep(42);
      Console.Beep(622, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(167);
      Console.Beep(415, 125);
      Console.Beep(440, 125);
      Console.Beep(523, 125);
      Thread.Sleep(125);
      Console.Beep(440, 125);
      Console.Beep(523, 125);
      Console.Beep(587, 125);
      Thread.Sleep(250);
      Console.Beep(784, 125);
      Console.Beep(740, 125);
      Console.Beep(698, 125);
      Thread.Sleep(42);
      Console.Beep(622, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(167);
      Console.Beep(698, 125);
      Thread.Sleep(125);
      Console.Beep(698, 125);
      Console.Beep(698, 125);
      Thread.Sleep(625);
      Console.Beep(784, 125);
      Console.Beep(740, 125);
      Console.Beep(698, 125);
      Thread.Sleep(42);
      Console.Beep(622, 125);
      Thread.Sleep(125);
      Console.Beep(659, 125);
      Thread.Sleep(167);
      Console.Beep(415, 125);
      Console.Beep(440, 125);
      Console.Beep(523, 125);
      Thread.Sleep(125);
      Console.Beep(440, 125);
      Console.Beep(523, 125);
      Console.Beep(587, 125);
      Thread.Sleep(250);
      Console.Beep(622, 125);
      Thread.Sleep(250);
      Console.Beep(587, 125);
      Thread.Sleep(250);
      Console.Beep(523, 125);
    }
  }
}
