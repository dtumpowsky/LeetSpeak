using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace LeetSpeakApp.Models
{
    public class LeetSpeak
    {
        private string _sentence;

        public LeetSpeak(string sentence)
        {
            _sentence = sentence;
        }

        public string GetSentence()
        {
            return _sentence;
        }

        public string ChangeCharacter()
        {
            char[] characterArray = _sentence.ToCharArray();
            string result = "";
            for (int i=0; i < characterArray.Length; i++)
            {

                if (characterArray[i] == 'e')
                {
                    result += '3';
                }
                else if (characterArray[i]  == 'o')
                {
                    result += '0';
                }
                else if (characterArray[i]  == 'i')
                {
                    result += '1';
                }
                else if (characterArray[i]  == 's')
                {
                    result += 'z';
                }
                else if (characterArray[i]  == 's')
                {
                    result += 'z';
                }
                else if (characterArray[i] == 't')
                    result += '7';
                else
                {
                  result += characterArray[i];
                }
            }
            return result;
        }


    }
}
