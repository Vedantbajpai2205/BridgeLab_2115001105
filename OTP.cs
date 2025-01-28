using System;

class OTP
{
    // Method to generate a 6-digit OTP number using Math.Random()
    public static int GenerateOTP()
    {
        Random rand = new Random();
        return rand.Next(100000, 1000000); 
    }

    // Method to ensure that the OTP numbers generated are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])  
                {
                    return false;  
                }
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        int[] otps = new int[10];  
        
        // Generate 10 OTP numbers and store them in the array
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOTP();
        }

        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }

        bool unique = AreOTPsUnique(otps);

        if (unique)
        {
            Console.WriteLine("\nAll OTPs are unique!");
        }
        else
        {
            Console.WriteLine("\nSome OTPs are repeated!");
        }
    }
}
