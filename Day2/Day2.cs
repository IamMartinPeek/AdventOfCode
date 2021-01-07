using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventCalendar.Day2
{
    public class Day2
    {
        private IEnumerable<PasswordPolicy> PasswordPolicies { get; set; }
        public Day2(string[] inputList)
        {
            PasswordPolicies = GetPasswordPolicyFromString(inputList);
        }
        public int Puzzle1()
        {
            var resultCount = 0;
            foreach (var passwordPolicy in PasswordPolicies)
            {
                var charFoundCount = passwordPolicy.Password.Count(c => c == passwordPolicy.CharToFind);
                if (passwordPolicy.FirstDigit <= charFoundCount && charFoundCount <= passwordPolicy.SecondDigit)
                {
                    resultCount++;
                }
            }
            return resultCount;
        }

        public int Puzzle2()
        {
            var resultCount = 0;
            foreach (var passwordPolicy in PasswordPolicies)
            {
                if (passwordPolicy.Password[passwordPolicy.FirstDigit-1] == passwordPolicy.CharToFind
                ^ passwordPolicy.Password[passwordPolicy.SecondDigit-1] == passwordPolicy.CharToFind)
                    resultCount++;
            }
            return resultCount;
        }

        private (int, int) GetRange(string[] input)
        {
            return (Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));
        }

        private IEnumerable<PasswordPolicy> GetPasswordPolicyFromString(string[] input)
        {
            foreach (var inputLine in input)
            {
                var inputs = inputLine.Split(" ");
                var (firstDigit, secondDigit) = GetRange(inputs[0].Split('-'));
                var searchChar = Convert.ToChar(inputs[1].Split(':')[0]);
                yield return new PasswordPolicy(firstDigit, secondDigit, searchChar, inputs[2]);
            }
        }
    }

    public class PasswordPolicy
    {
        public PasswordPolicy(int firstDigit, int secondDigit, char charToFind, string password)
        {
            FirstDigit = firstDigit;
            SecondDigit = secondDigit;
            CharToFind = charToFind;
            Password = password;
        }
        public int FirstDigit { get; set; }
        public int SecondDigit { get; set; }
        public char CharToFind { get; set; }
        public string Password { get; set; }
    }
}