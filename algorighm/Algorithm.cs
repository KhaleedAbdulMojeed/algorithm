
public class Algorithm
{
    public static List<int> GetVowelPositions(string s)
    {
        // Define vowels
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        // List to store positions of vowels
        List<int> positions = new List<int>();

        // Iterate through the string
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];

            // Check if the current character is a vowel
            for (int j = 0; j < vowels.Length; j++)
            {
                if (currentChar == vowels[j])
                {
                    positions.Add(i);
                    break;
                }
            }
        }

        return positions;
    }
    public static string TransformString(string inputString)
    {
        char[] result = new char[inputString.Length];
        for (int i = 0; i < inputString.Length; i++)
        {
            char c = inputString[i];
            if (char.IsLower(c))
            {
                result[i] = char.ToUpper(c);
            }
            else if (char.IsUpper(c))
            {
                result[i] = char.ToLower(c);
            }
            else
            {
                result[i] = c;
            }
        }
        return new string(result);
    }
    public static string ShiftLetters(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];


            if (c >= 'A' && c <= 'Z')
            {
                result[i] = (char)((c - 'A' + 1) % 26 + 'A');
            }

            else if (c >= 'a' && c <= 'z')khaleedokikiola
            {
                result[i] = (char)((c - 'a' + 1) % 26 + 'a');
            }

            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }
}

