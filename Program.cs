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
      Song sp = new Song();
      while (playing)
      {
        Thread s = new Thread(sp.Play);
        s.Start();
        Random rnd = new Random();
        string[] ComputerChoice = { "rock", "paper", "scissors" };
        int cChoice = rnd.Next(ComputerChoice.Length);
        Console.WriteLine("rock, paper or scissors?");
        string UserResponse = Console.ReadLine();
        if (UserResponse != "rock" & UserResponse != "paper" & UserResponse != "scissors")
        {
          Console.WriteLine("I dont remember giving you that option!");
          sp.SongPlaying = false;
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
          sp.SongPlaying = false;
        }

      }

    }
  }
  class Song
  {
    public bool SongPlaying = true;

    void Beep(int freq, int dur)
    {
      if (SongPlaying)
      {
        Console.Beep(freq, dur);
      }
    }
    void Sleep(int dur)
    {
      if (SongPlaying)
      {
        Thread.Sleep(dur);
      }
    }
    public void Play()
    {
      Beep(659, 125);
      Beep(659, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(167);
      Beep(523, 125);
      Beep(659, 125);
      Sleep(125);
      Beep(784, 125);
      Sleep(375);
      Beep(392, 125);
      Sleep(375);
      Beep(523, 125);
      Sleep(250);
      Beep(392, 125);
      Sleep(250);
      Beep(330, 125);
      Sleep(250);
      Beep(440, 125);
      Sleep(125);
      Beep(494, 125);
      Sleep(125);
      Beep(466, 125);
      Sleep(42);
      Beep(440, 125);
      Sleep(125);
      Beep(392, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(125);
      Beep(784, 125);
      Sleep(125);
      Beep(880, 125);
      Sleep(125);
      Beep(698, 125);
      Beep(784, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(125);
      Beep(523, 125);
      Sleep(125);
      Beep(587, 125);
      Beep(494, 125);
      Sleep(125);
      Beep(523, 125);
      Sleep(250);
      Beep(392, 125);
      Sleep(250);
      Beep(330, 125);
      Sleep(250);
      Beep(440, 125);
      Sleep(125);
      Beep(494, 125);
      Sleep(125);
      Beep(466, 125);
      Sleep(42);
      Beep(440, 125);
      Sleep(125);
      Beep(392, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(125);
      Beep(784, 125);
      Sleep(125);
      Beep(880, 125);
      Sleep(125);
      Beep(698, 125);
      Beep(784, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(125);
      Beep(523, 125);
      Sleep(125);
      Beep(587, 125);
      Beep(494, 125);
      Sleep(375);
      Beep(784, 125);
      Beep(740, 125);
      Beep(698, 125);
      Sleep(42);
      Beep(622, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(167);
      Beep(415, 125);
      Beep(440, 125);
      Beep(523, 125);
      Sleep(125);
      Beep(440, 125);
      Beep(523, 125);
      Beep(587, 125);
      Sleep(250);
      Beep(784, 125);
      Beep(740, 125);
      Beep(698, 125);
      Sleep(42);
      Beep(622, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(167);
      Beep(698, 125);
      Sleep(125);
      Beep(698, 125);
      Beep(698, 125);
      Sleep(625);
      Beep(784, 125);
      Beep(740, 125);
      Beep(698, 125);
      Sleep(42);
      Beep(622, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(167);
      Beep(415, 125);
      Beep(440, 125);
      Beep(523, 125);
      Sleep(125);
      Beep(440, 125);
      Beep(523, 125);
      Beep(587, 125);
      Sleep(250);
      Beep(622, 125);
      Sleep(250);
      Beep(587, 125);
      Sleep(250);
      Beep(523, 125);
      Sleep(1125);
      Beep(784, 125);
      Beep(740, 125);
      Beep(698, 125);
      Sleep(42);
      Beep(622, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(167);
      Beep(415, 125);
      Beep(440, 125);
      Beep(523, 125);
      Sleep(125);
      Beep(440, 125);
      Beep(523, 125);
      Beep(587, 125);
      Sleep(250);
      Beep(784, 125);
      Beep(740, 125);
      Beep(698, 125);
      Sleep(42);
      Beep(622, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(167);
      Beep(698, 125);
      Sleep(125);
      Beep(698, 125);
      Beep(698, 125);
      Sleep(625);
      Beep(784, 125);
      Beep(740, 125);
      Beep(698, 125);
      Sleep(42);
      Beep(622, 125);
      Sleep(125);
      Beep(659, 125);
      Sleep(167);
      Beep(415, 125);
      Beep(440, 125);
      Beep(523, 125);
      Sleep(125);
      Beep(440, 125);
      Beep(523, 125);
      Beep(587, 125);
      Sleep(250);
      Beep(622, 125);
      Sleep(250);
      Beep(587, 125);
      Sleep(250);
      Beep(523, 125);
    }
  }
}

