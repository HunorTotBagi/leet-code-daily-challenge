namespace Src._10_Oct;

public class FinalValueAfterOperationsSolution
{
    public static int FinalValueAfterOperations(string[] operations)
    {
        var x = 0;
        
        foreach (var operation in operations)
        {
            if (operation == "++X" || operation == "X++")
                x++;

            if (operation == "--X" || operation == "X--")
                x--;
        }

        return x;
    }
}
