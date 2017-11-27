using System;
using System.Text;
using System.Collections.Generic;

namespace Treehouse
{
    static class MorseCodeTranslator
    {
      //create a lookup table perfect use case for a dictionary. Two types of parameters: Key, value.
      // uses hashcodes to quickly find the keys.

      private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>
      {
        {' ', "/"},
        {'A', ".-"},
        {'B', "-..."},
        {'C', "-.-."},
        {'D', "-.."},
        {'E', "."},
        {'F', "..-."},
        {'G', "--."},
        {'H', "...."},
        {'I', ".."},
        {'J', ".---"},
        {'K', "-.-"},
        {'L', ".-.."},
        {'M', "--"},
        {'N', "-."},
        {'O', "---"},
        {'P', ".--."},
        {'Q', "--.-"},
        {'R', ".-."},
        {'S', "..."},
        {'T', "-"},
        {'U', "..-"},
        {'V', "...-"},
        {'W', ".--"},
        {'X', "-..-"},
        {'Y', "-.--"},
        {'Z', "--.."},
        {'1', ".----"},
        {'2', "..---"},
        {'3', "...--"},
        {'4', "....-"},
        {'5', "....."},
        {'6', "-...."},
        {'7', "--..."},
        {'8', "---.."},
        {'9', "----."},
        {'0', "-----"},
        {',', "--..--"},
        {'.', ".-.-.-"},
        {'?', "..--.."},
        {';', "-.-.-."},
        {':', "---..."},
        {'/', "-..-."},
        {'-', "-....-"},
        {'\'', ".----."},
        {'"', ".-..-."},
        {'(', "-.--."},
        {')', "-.--.-"},
        {'=', "-...-"},
        {'+', ".-.-."},
        {'@', ".--.-."},
        {'!', "-.-.--"},
        {'Á', ".--.-"},
        {'É', "..-.."},
        {'Ö', "---."},
        {'Ä', ".-.-"},
        {'Ñ', "--.--"},
        {'Ü', "..--"}
      };

//now to create the other side of the translation using the above dictionary.
      public static Dictionary<string, char> _morseToText = new Dictionary<string, char>();
      // now we'll fill this dictionary with a static constructor. runs once and only once. we want these dictionaries to be completely static
      static MorseCodeTranslator() //no prive/public. don't work that way.
      {
        foreach(KeyValuePair<char, string> code in _textToMorse)
        {
            // _morseToText[code.Value] = code.Key;
            _morseToText.Add(code.Value, code.Key);
        }

        
      }

      public static string ToMorse(string input)
      {
        List<string> output = new List<string>(input.Length);

        foreach(char character in input.ToUpper())
        {
            // what if someone enters a character not found? need to add a try/catch.
            try
            {
                string morseCode = _textToMorse[character];
                output.Add(morseCode);
            }
            catch(KeyNotFoundException)
            {
                output.Add("!");
            }
        }

        return string.Join(" ", output);

      }


    }
}