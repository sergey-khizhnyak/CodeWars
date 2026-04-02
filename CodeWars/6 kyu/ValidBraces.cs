namespace CodeWars._6_kyu;

// Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return true if the string is valid, and false if it's invalid.
//
//     This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets [], and curly braces {}. Thanks to @arnedag for the idea!
//
//     All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{}.

// "(){}[]"   =>  True
// "([{}])"   =>  True
// "(}"       =>  False
// "[(])"     =>  False
// "[({})](]" =>  False
    
public class ValidBraces
{
    private static Dictionary<char, char> _bracesDict = new()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };
    
    
    public static bool IsValidBraces(string braces) {
        var stack = new Stack<char>();
        foreach (var letter in braces)
        {
            if (_bracesDict.ContainsKey(letter))
            {
                stack.Push(letter);
            }
            else
            {
                if (stack.Count == 0)
                    return false;
                
                var last = stack.Pop();
                
               if (_bracesDict[last] != letter)
                   return false;
            }
        }
        return stack.Count == 0;
    }
}
