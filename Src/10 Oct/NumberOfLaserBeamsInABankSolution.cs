namespace Src._10_Oct;

public class NumberOfLaserBeamsInABankSolution
{
    public static int NumberOfBeams(string[] bank)
    {
        var result = 0;
        var prevRowDevices = 0;

        foreach (var row in bank)
        {
            var devices = 0;
            foreach (var c in row)
                if (c == '1')
                    devices++;
            
            if (devices == 0)
                continue;

            result += prevRowDevices * devices;
            prevRowDevices = devices;
        }

        return result;
    }
}
