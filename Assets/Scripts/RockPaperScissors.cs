using UnityEngine;
using TMPro;

public class RockPaperScissors : MonoBehaviour
{
    public MinimaxAI minimax;
    public TMP_Text resultText;

    // Method called when the player selects a choice
    public void PlayerChoice(string playerChoice)
    {
        MinimaxAI.Choice choice;
        switch (playerChoice)
        {
            case "Rock":
                choice = MinimaxAI.Choice.Rock;
                break;
            case "Paper":
                choice = MinimaxAI.Choice.Paper;
                break;
            case "Scissors":
                choice = MinimaxAI.Choice.Scissors;
                break;
            default:
                choice = MinimaxAI.Choice.Rock;
                break;
        }

        // Generate the computer's choice using the Minimax algorithm
        MinimaxAI.Choice computerChoice = minimax.GetBestMove();

        // Determine the winner based on the choices
        string winner = DetermineWinner(choice, computerChoice);

        // Update the result text
        resultText.text = "Player chose: " + choice.ToString() + "\nComputer chose: " + computerChoice.ToString() + "\n" + winner;
    }

    // Method to determine the winner based on the choices
    string DetermineWinner(MinimaxAI.Choice playerChoice, MinimaxAI.Choice computerChoice)
    {
        // Check for a tie
        if (playerChoice == computerChoice)
        {
            return "It's a tie!";
        }
        // Check for player wins
        else if ((playerChoice == MinimaxAI.Choice.Rock && computerChoice == MinimaxAI.Choice.Scissors) ||
                 (playerChoice == MinimaxAI.Choice.Paper && computerChoice == MinimaxAI.Choice.Rock) ||
                 (playerChoice == MinimaxAI.Choice.Scissors && computerChoice == MinimaxAI.Choice.Paper))
        {
            return "Player wins!";
        }
        // Otherwise, computer wins
        else
        {
            return "Computer wins!";
        }
    }

    // Method called when the "Play Again" button is clicked
    public void PlayAgain()
    {
        // Clear the result text
        resultText.text = "";
    }
}