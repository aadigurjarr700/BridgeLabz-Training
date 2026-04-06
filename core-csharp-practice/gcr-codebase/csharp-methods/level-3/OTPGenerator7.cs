using System;

class OTPGenerator7
{
    public static int GenerateOTP()//generate a 6 digit otp
    {
        Random rand = new Random();
        return rand.Next(100000, 1000000);//6-digit number
    }

    public static bool AreUnique(int[] otps)//cehgck all oyts are unique or not 
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

    static void Main()
    {
        int[] otps = new int[10];

        //genrate 10 OTPs
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }

        //check uniqueness
        if (AreUnique(otps))
        {
            Console.WriteLine("All OTPs are unique.");
        }
        else
        {
            Console.WriteLine("Some OTPs are repeated.");
        }
    }
}
