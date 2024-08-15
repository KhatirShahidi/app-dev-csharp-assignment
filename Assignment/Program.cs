using System;

// Question 1: String Concatenation and Arithmetic Operations Task: Write a program that asks the user to enter their first name, last name, and age. Concatenate the first and last name to display the full name. Then, calculate how many years are left until the user turns 100 and display a message. Expected Output: Enter your first name: John Enter your last name: Doe Enter your age: 25 Hello, John Doe. You will turn 100 in 75 years. 

// namespace FullName

// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter your first name: ");
//             string firstName = Console.ReadLine();
//             Console.Write("Enter your last name: ");
//             string lastName = Console.ReadLine();
//             Console.Write("Enter your age: ");
//             int age = int.Parse(Console.ReadLine());
//             string fullName = firstName + " " + lastName;
//             Console.WriteLine("Hello, " + fullName + ".");
//             int yearsLeft = 100 - age;
//             Console.WriteLine("You will turn 100 in " + yearsLeft + " years.");
//         }
//     }
// }


// Question 2: String Length and Looping Task: Create a program that asks the user to enter a word. Display each character of the word on a new line, along with the position of the character. 
// namespace StringLength
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter a word: ");
//             string word = Console.ReadLine();
//             int length = word.Length;
//             for (int i = 0; i < length; i++)
//             {
//                 Console.WriteLine("Position " + i + ": " + word[i]);
//             }
//         }
//     }
// }

// Question 3: String Comparison and Conditional Statements Task: Write a program that compares two strings entered by the user. Check if they are equal, ignoring case, and display an appropriate message. Expected Output: Enter the first string: apple Enter the second string: Apple The strings are equal.


// namespace StringComparison
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter the first string: ");
//             string firstString = Console.ReadLine();
//             Console.Write("Enter the second string: ");
//             string secondString = Console.ReadLine();
//             if (firstString.ToLower() == secondString.ToLower())
//             {
//                 Console.WriteLine("The strings are equal.");
//             }
//             else
//             {
//                 Console.WriteLine("The strings are not equal.");
//             }
//         }
//     }
// }

// Question 4: String Interpolation and Mathematical Calculations Task: Create a program that asks the user for a radius and then calculates and displays the area and circumference of a circle using string interpolation. Expected Output: Enter the radius of the circle: 5 For a circle with radius 5, Area: 78.54, Circumference: 31.42


// namespace StringInterpolation
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter the radius of the circle: ");
//             double radius = double.Parse(Console.ReadLine());
//             double area = Math.PI * radius * radius;
//             double circumference = 2 * Math.PI * radius;
//             Console.WriteLine("For a circle with radius {0}, Area: {1}, Circumference: {2}", radius, area, circumference);
//         }
//     }
// }

// Question 5: Substring and Vowel Counting Task: Write a program that asks the user to enter a sentence. Extract the first word of the sentence and count the number of vowels in that word. Expected Output: Enter a sentence: Hello world The first word is 'Hello', which contains 2 vowels. 

// namespace SubstringAndVowelCounting
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter a sentence: ");
//             string sentence = Console.ReadLine();
//             string firstWord = sentence.Substring(0, sentence.
//                 IndexOf(" "));
//             int vowelCount = 0;
//             foreach (char c in firstWord)
//             {
//                 if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
//                 {
//                     vowelCount++;
//                 }
//             }
//             if (vowelCount == 1)
//             {
//                 Console.WriteLine("The first word is" + firstWord + ", which contains " + vowelCount + " vowel.");
//             }
//             else
//             {
//                 Console.WriteLine("The first word is " + firstWord + ", which contains " + vowelCount + " vowels.");
//             }
//         }
//     }
// }

// Question 6: String Reversal and Palindrome Check Task: Create a program that reverses a string entered by the user and checks if it is a palindrome. Display the reversed string and whether it is a palindrome. Expected Output: Enter a string: madam Reversed String: madam The string is a palindrome. 

// namespace StringReversalAndPalindromeCheck
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter a string: ");
//             string input = Console.ReadLine();
//             string reversed = new string(input.Reverse().ToArray());
//             if (input == reversed)
//             {
//                 Console.WriteLine("The string is a palindrome.");
//             }
//             else
//             {
//                 Console.WriteLine("The string is not a palindrome.");
//             }
//         }
//     }
// }

// Question 7: Character Frequency Counter Task: Write a program that counts the frequency of each character in a string entered by the user. Display the results. Expected Output: Enter a string: hello Character frequencies: h: 1 e: 1 l: 2 o: 1 

// namespace CharacterFrequencyCounter
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter a string: ");
//             string input = Console.ReadLine();
//             Dictionary<char, int> frequency = new Dictionary<char, int>();
//             foreach (char c in input)
//             {
//                 if (frequency.ContainsKey(c))
//                 {
//                     frequency[c]++;
//                 }
//                 else
//                 {
//                     frequency[c] = 1;
//                 }
//             }
//             Console.WriteLine("Character frequencies: " + string.Join(", ", frequency.Select(x => $"{x.Key}: {x.Value}")));
//         }
//     }
// }

// Question 8: String Formatting and Date Calculation Task: Create a program that asks the user for their birthdate (in the format YYYY-MMDD) and calculates how many days they have lived. Display the result using string formatting. Expected Output: Enter your birthdate (YYYY-MM-DD): 2000-01-01 You have lived 8400 days. 

// namespace StringFormattingAndDateCalculation
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter your birthdate (YYYY-MM-DD): ");
//             DateTime birthdate = DateTime.Parse(Console.ReadLine());
//             TimeSpan age = DateTime.Now - birthdate;
//             Console.WriteLine("You have lived {0} days.", age.Days);
//         }
//     }
// }

// Question 9: Capitalization and Looping Task: Write a program that capitalizes the first letter of each word in a sentence entered by the user and displays the result. Expected Output: Enter a sentence: hello world from csharp Capitalized Sentence: Hello World From Csharp 

// namespace CapitalizationAndLooping
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter a sentence: ");
//             string sentence = Console.ReadLine();
//             string words = sentence.ToLower();
//             string[] wordsArray = words.Split(' ');
//             for (int i = 0; i < wordsArray.Length; i++)
//             {
//                 wordsArray[i] = char.ToUpper(wordsArray[i][0]) + wordsArray[i].Substring(1);
//             }
//             string capitalizedSentence = string.Join(" ", wordsArray);
//             Console.WriteLine("Capitalized Sentence: " + capitalizedSentence);
//         }
//     }
// }

// Question 10: String Splitting and Word Count Task: Create a program that splits a sentence entered by the user into individual words. Display the number of words and each word on a new line. Expected Output: Enter a sentence: CSharp is a powerful language Number of words: 5 Word 1: CSharp Word 2: is Word 3: a Word 4: powerful Word 5: language 

// namespace StringSplittingAndWordCount
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter a sentence: ");
//             string sentence = Console.ReadLine();
//             string[] words = sentence.Split(' ');
//             Console.WriteLine("Number of words: " + words.Length);
//             for (int i = 0; i < words.Length; i++)
//             {
//                 Console.WriteLine("Word " + (i + 1) + ": " + words[i]);
//             }
//         }
//     }
// }

// Question 11: Anagram Checker [Can skip if can’t solve] Task: Write a program that checks if two strings entered by the user are anagrams (contain the same characters in a different order). Ignore case and spaces. Expected Output: Enter the first string: listen Enter the second string: silent The strings are anagrams. 

// namespace AnagramChecker
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter the first string: ");
//             string firstString = string.Concat(Console.ReadLine().ToLower().Where(c => !char.IsWhiteSpace(c)));
//             Console.Write("Enter the second string: ");
//             string secondString = string.Concat(Console.ReadLine().ToLower().Where(c => !char.IsWhiteSpace(c)));
//             if (firstString.Length != secondString.Length)
//             {
//                 Console.WriteLine("The strings are not anagrams.");
//             }
//             else
//             {
//                 char[] firstCharArray = firstString.ToCharArray();
//                 char[] secondCharArray = secondString.ToCharArray();
//                 Array.Sort(firstCharArray);
//                 Array.Sort(secondCharArray);
//                 if (new string(firstCharArray) == new string(secondCharArray))
//                 {
//                     Console.WriteLine("The strings are anagrams.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("The strings are not anagrams.");
//                 }
//             }
//         }
//     }
// }

// Question 12: Question 12: String Compression Algorithm [Can skip if can’t solve] Task: Create a program that compresses a string using the counts of repeated characters. For example, the string "aaabbc" becomes "a3b2c1". If the compressed string is not smaller, return the original string. Expected Output: Enter a string: aaabbc Compressed String: a3b2c1 

// namespace StringCompression
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter a string: ");
//             string input = Console.ReadLine();
//             string compressed = Compress(input);
//             Console.WriteLine("Compressed String: " + compressed);
//         }

//         static string Compress(string input)
//         {
//             if (input == null || input.Length == 0)
//             {
//                 return input;
//             }
            
//             string compressed = "";
//             int count = 0;

//             for (int i = 0; i < input.Length; i++)
//             {
//                 count++;
//                 if (i + 1 >= input.Length || input[i] != input[i + 1])
//                 {
//                     compressed += input[i] + count.ToString();
//                     count = 0;
//                 }
//             }
//             return compressed;
//         }
//     }
// }


// Question 13: Caesar Cipher [Can skip if can’t solve] Task: Write a program that implements a Caesar cipher, which shifts each letter in a string by a given number of positions. The program should handle both encryption and decryption. Expected Output:  Enter a string to encrypt: hello Enter shift amount: 3 Encrypted String: khoor Enter a string to decrypt: khoor Enter shift amount: 3 Decrypted String: hello 

// namespace CaesarCipher
// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.Write("Enter a string to encrypt: ");
//             string input = Console.ReadLine();
//             Console.Write("Enter shift amount: ");
//             int shift = int.Parse(Console.ReadLine());
//             string encrypted = Encrypt(input, shift);
//             Console.WriteLine("Encrypted String: " + encrypted);
//             Console.Write("Enter a string to decrypt: ");
//             input = Console.ReadLine();
//             Console.Write("Enter shift amount: ");
//             shift = int.Parse(Console.ReadLine());
//             string decrypted = Decrypt(input, shift);
//             Console.WriteLine("Decrypted String: " + decrypted);
//         }

//         static string Encrypt(string input, int shift)
//         {
//             return CaesarShift(input, shift);
//         }

//         static string Decrypt(string input, int shift)
//         {
//             return CaesarShift(input, -shift);
//         }

//         static string CaesarShift(string input, int shift)
//         {
//             char[] output = new char[input.Length];
//             for (int i = 0; i < input.Length; i++)
//             {
//                 char c = input[i];

//                 if (char.IsLetter(c))
//                 {
//                     char offset = char.IsUpper(c) ? 'A' : 'a';
//                     c = (char)(((c - offset + shift) % 26 + 26) % 26 + offset);
//                 }

//                 output[i] = c;
//             }
//             return new string(output);
//         }
// }
// }


// Question 14: Longest Word Finder Task: Create a program that finds the longest word in a sentence entered by the user. If there are multiple words of the same length, display all of them. Expected Output: Enter a sentence: CSharp is an amazing programming language Longest word(s): programming, language 

// namespace LongestWordFinder
// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.Write("Enter a sentence: ");
//             string sentence = Console.ReadLine();
//             string[] words = sentence.Split(' ');
//             int maxLength = 0;
//             string longestWord = "";
//             foreach (string word in words)
//             {
//                 if (word.Length > maxLength)
//                 {
//                     maxLength = word.Length;
//                     longestWord = word;
//                 }
//             }
//             Console.WriteLine("Longest word(s): " + longestWord);
//         }
//     }
// }

// Question 15: Advanced Palindrome Checker [Can skip if can’t solve] Task: Write a program that checks if a sentence is a palindrome, ignoring spaces, punctuation, and case. Expected Output: Enter a sentence: A man a plan a canal Panama The sentence is a palindrome. 

// namespace AdvancedPalindromeChecker
// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.Write("Enter a sentence: ");
//             string sentence = Console.ReadLine();

//             string cleanedInput = CleanInput(sentence);

//             if (IsPalindrome(cleanedInput))
//             {
//                 Console.WriteLine("The sentence is a palindrome.");
//             }
//             else
//             {
//                 Console.WriteLine("The sentence is not a palindrome.");
//             }
//         }

//         static string CleanInput(string input)
//         {
//             char[] cleanInput = new char[input.Length];
//             int index = 0;

//             for (int i = 0; i < input.Length; i++)
//             {
//                 if (char.IsLetterOrDigit(input[i]))
//                 {
//                     cleanInput[index++] = char.ToLower(input[i]);
//                 }
//             }

//             return new string(cleanInput, 0, index);
//         }

//         static bool IsPalindrome(string input)
//         {
//             int left = 0;
//             int right = input.Length - 1;

//             while (left < right)
//             {
//                 if (input[left] != input[right])
//                 {
//                     return false;
//                 }
//                 left++;
//                 right--;
//             }
//             return true;
//         }
//     }
// }

// Question 16: String Permutations [Can skip if can’t solve] Task: Create a program that generates all permutations of a string entered by the user and displays them. Expected Output: Enter a string: abc Permutations: abc acb bac bca cab cba 

// namespace StringPermutations

// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.Write("Enter a string: ");
//             string input = Console.ReadLine();
//             string[] permutations = GeneratePermutations(input);
//             Console.WriteLine("Permutations: " + string.Join(", ", permutations));
//         }

//         static string[] GeneratePermutations(string input)
//         {
//             if (input.Length == 1)
//             {
//                 return new string[] { input };
//             }

//             List<string> permutations = new List<string>();

//             foreach (char c in input)
//             {
//                 string remaining = input.Replace(c.ToString(), "");
//                 string[] remainingPermutations = GeneratePermutations(remaining);
//                 foreach (string p in remainingPermutations)
//                 {
//                     permutations.Add(c + p);
//                 }
//             }

//             return permutations.ToArray();
//         }
//     }
// }

// Question 17: Password Strength Checker [Can skip if can’t solve] Task: Write a program that checks the strength of a password entered by the user. The program should evaluate length, use of uppercase and lowercase letters, digits, and special characters, and provide feedback on the password’s strength. Expected Output: Enter a password: P@ssw0rd Password Strength: Strong 

// namespace PasswordStrengthChecker

// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.Write("Enter a password: ");
//             string password = Console.ReadLine();

//             string strength = GetPasswordStrength(password);

//             Console.WriteLine("Password Strength: " + strength);
//         }

//         static string GetPasswordStrength(string password)
//         {
//             bool hasUpper = false;
//             bool hasLower = false;
//             bool hasDigit = false;
//             bool hasSpecial = false;

//             foreach (char c in password)
//             {
//                 if (char.IsUpper(c))
//                 {
//                     hasUpper = true;
//                 }
//                 else if (char.IsLower(c))
//                 {
//                     hasLower = true;
//                 }
//                 else if (char.IsDigit(c))
//                 {
//                     hasDigit = true;
//                 }
//                 else
//                 {
//                     hasSpecial = true;
//                 }
//             }

//             int strengthLevel = 0;

//             if (password.Length >= 8)
//             {
//                 strengthLevel++;
//             }

//             if (hasUpper && hasLower)
//             {
//                 strengthLevel++;
//             }

//             if (hasDigit)
//             {
//                 strengthLevel++;
//             }

//             if (hasSpecial)
//             {
//                 strengthLevel++;
//             }

//             switch (strengthLevel)
//             {
//                 case 1:
//                     return "Weak";
//                 case 2:
//                     return "Medium";
//                 case 3:
//                     return "Strong";
//                 case 4:
//                     return "Very Strong";
//                 default:
//                     return "Invalid Password";
//             }
//         }
//     }
// }

// Question 18: Advanced Substring Search Task: Create a program that finds all occurrences of a substring within a string and replaces them with another substring provided by the user. Expected Output: Enter the main string: The rain in Spain stays mainly in the plain Enter the substring to find: in Enter the substring to replace it with: out Resulting String: The raout out Spaout stays maoutly out the plaout 

// namespace AdvancedSubstringSearch

// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.Write("Enter the main string: ");
//             string mainString = Console.ReadLine();
//             Console.Write("Enter the substring to find: ");
//             string substringToFind = Console.ReadLine();
//             Console.Write("Enter the substring to replace it with: ");
//             string substringToReplace = Console.ReadLine();
//             string result = FindAndReplace(mainString, substringToFind, substringToReplace);
//             Console.WriteLine("Resulting String: " + result);
//         }

//         static string FindAndReplace(string mainString, string substringToFind, string substringToReplace)
//         {
//             int index = mainString.IndexOf(substringToFind);
//             while (index != -1)
//             {
//                 mainString = mainString.Remove(index, substringToFind.Length).Insert(index, substringToReplace);
//                 index = mainString.IndexOf(substringToFind, index + substringToReplace.Length);
//             }
//             return mainString;
//         }
//     }
// }

// Question 19: Sentence Reversal Task: Write a program that reverses the order of words in a sentence entered by the user while keeping the words themselves intact. Expected Output: Enter a sentence: CSharp is fun Reversed Sentence: fun is CSharp 

// namespace SentenceReversal

// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.Write("Enter a sentence: ");
//             string sentence = Console.ReadLine();
//             string reversedSentence = ReverseWords(sentence);
//             Console.WriteLine("Reversed Sentence: " + reversedSentence);
//         }

//         static string ReverseWords(string sentence)
//         {
//             string[] words = sentence.Split(' ');
//             Array.Reverse(words);
//             return string.Join(" ", words);
//         }
//     }
// }

// Question 20: Base Conversion  Task: Create a program that converts a number from one base (e.g., binary, octal, hexadecimal) to another base. The user should input the number, its current base, and the desired base for conversion. Expected Output:  Enter the number: 1010 Enter the current base (2 for binary, 8 for octal, 16 for hexadecimal): 2 Enter the desired base (10 for decimal, 8 for octal, 16 for hexadecimal): 10 Converted Number: 10 

// namespace BaseConversion

// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.Write("Enter the number: ");
//             string number = Console.ReadLine();
//             Console.Write("Enter the current base (2 for binary, 8 for octal, 16 for hexadecimal): ");
//             int currentBase = int.Parse(Console.ReadLine());
//             Console.Write("Enter the desired base (10 for decimal, 8 for octal, 16 for hexadecimal): ");
//             int desiredBase = int.Parse(Console.ReadLine());
//             string convertedNumber = ConvertNumber(number, currentBase, desiredBase);
//             Console.WriteLine("Converted Number: " + convertedNumber);
//         }

//         static string ConvertNumber(string number, int currentBase, int desiredBase)
//         {
//             int numberValue = Convert.ToInt32(number, currentBase);
//             return Convert.ToString(numberValue, desiredBase);
//         }
//     }
// }