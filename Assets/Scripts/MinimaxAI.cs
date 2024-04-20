using UnityEngine;

public class MinimaxAI : MonoBehaviour
{
    // Enum to represent choices
    public enum Choice { Rock, Paper, Scissors }

    // Method to calculate the best move for the computer
    public Choice GetBestMove()
    {
        // Generate a random number to determine the choice
        int randomNumber = UnityEngine.Random.Range(0, 3);
        
        // 33% chance of choosing each option
        if (randomNumber == 0)
            return Choice.Rock;
        else if (randomNumber == 1)
            return Choice.Paper;
        else
            return Choice.Scissors;
    }
}