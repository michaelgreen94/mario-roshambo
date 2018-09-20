namespace roshambo.Models
{
  public class Game
  {
    public string ComputerChoice { get; set; }
    public string UserResponse { get; set; }

    public string GameResults()
    {
      if (UserResponse == ComputerChoice)
      {
        return "Tie";
      }
      else if (UserResponse == "rock" & ComputerChoice == "paper")
      {
        return "Loser";
      }
      else if (UserResponse == "paper" & ComputerChoice == "scissors")
      {
        return "Loser";
      }
      else if (UserResponse == "scissors" & ComputerChoice == "rock")
      {
        return "Loser";
      }
      else return "Winner";
    }

    public Game(string userResponse, string computerChoice)
    {
      ComputerChoice = computerChoice;
      UserResponse = userResponse;
    }
  }
}