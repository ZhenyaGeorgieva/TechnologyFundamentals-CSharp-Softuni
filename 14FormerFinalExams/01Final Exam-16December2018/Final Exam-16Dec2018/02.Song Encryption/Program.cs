using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02SongEnscryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string artistSongPattern = @"^(?<artist>[A-Z]{1}[a-z\'\s]{1,}):(?<song>[A-Z\s]{1,})$";
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "end")
                {
                    break;
                }
                else
                {
                    if (Regex.IsMatch(text, artistSongPattern))
                    {
                        var artistSongCollection = Regex.Matches(text, artistSongPattern);
                        string artist = string.Empty;
                        string song = string.Empty;
                        StringBuilder sb = new StringBuilder();
                        foreach (Match item in artistSongCollection)
                        {
                            artist = item.Groups["artist"].Value.ToString();
                            song = item.Groups["song"].Value.ToString();
                            int key = artist.Length;
                            for (int i = 0; i < artist.Length; i++)
                            {
                                char symbol = artist[i];

                                if (symbol == ' ')
                                {
                                    sb.Append(" ");
                                }
                                else if (symbol == '\'')
                                {
                                    sb.Append("'");
                                }
                                else
                                {
                                    int asciiCode = (int)symbol;
                                    int asciiCodeKey = asciiCode + key;
                                    if (key + asciiCode >= 65
                                        && key + asciiCode <= 90
                                        && char.IsUpper(symbol))
                                    {
                                        char newSymbol = (char)(key + asciiCode);
                                        sb.Append(newSymbol);
                                    }
                                    if (key + asciiCode > 90
                                        && char.IsUpper(symbol))
                                    {
                                        char newSymbol = (char)(key + asciiCode - 26);
                                        sb.Append(newSymbol);
                                    }
                                    if (key + asciiCode >= 97
                                        && key + asciiCode <= 122
                                        && char.IsLower(symbol))
                                    {
                                        char newSymbol = (char)(key + asciiCode);
                                        sb.Append(newSymbol);
                                    }
                                    if (key + asciiCode > 122
                                        && char.IsLower(symbol))
                                    {
                                        char newSymbol = (char)(key + asciiCode - 26);
                                        sb.Append(newSymbol);
                                    }
                                }
                            }
                            sb.Append("@");
                            for (int j = 0; j < song.Length; j++)
                            {
                                char symbol = song[j];
                                if (symbol == ' ')
                                {
                                    sb.Append(" ");
                                }
                                else
                                {
                                    int asciiCode = (int)symbol;
                                    if (key + asciiCode >= 65
                                        && key + asciiCode <= 90
                                        && char.IsUpper(symbol))
                                    {
                                        char newSymbol = (char)(key + asciiCode);
                                        sb.Append(newSymbol);
                                    }
                                    if (key + asciiCode > 90
                                        && char.IsUpper(symbol))
                                    {
                                        char newSymbol = (char)(key + asciiCode - 26);
                                        sb.Append(newSymbol);
                                    }
                                    if (key + asciiCode >= 97
                                        && key + asciiCode <= 122
                                        && char.IsLower(symbol))
                                    {
                                        char newSymbol = (char)(key + asciiCode);
                                        sb.Append(newSymbol);
                                    }
                                    if (key + asciiCode > 122
                                        && char.IsLower(symbol))
                                    {
                                        char newSymbol = (char)(key + asciiCode - 26);
                                        sb.Append(newSymbol);
                                    }
                                }
                            }
                        }
                        Console.WriteLine($"Successful encryption: {sb.ToString()}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }
            }
        }
    }
}
