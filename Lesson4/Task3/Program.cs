string GerLetters(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (IsAsciiLetter(e) == true)
        {
            letters += e;
        }
    }
    return letters;
}









string str = Console.ReadLine();
string result = GerLetters(str);
System.Console.WriteLine(result);