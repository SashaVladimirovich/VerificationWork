Console.Clear();
string FillText(string text, int wordCount)
{
    string librarySymbol = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

    for (int i = 0; i < wordCount; i++)
    {
        string word = String.Empty;
        int wordLength = new Random().Next(1, 15); 
        for (int j = 0; j < wordLength; j++)
        {
            word = word + librarySymbol[new Random().Next(0, 62)];
        }
        text += word + " ";
    }
    return text;
}
string PrintText(string text)
{
    return "|" + String.Join(' ', text) + "|";
}
string DelNumber(string text)
{
string newText = String.Empty;
for(int index = 0; index < text.Length; index++)
{
    char symbol = text[index];
    bool flag = symbol >= '0' && symbol <= '9';
    if (flag == false)
    {
        newText = newText + text[index];
    }
   
}
return newText;
}

int wordCount = new Random().Next(2, 30);
string text = String.Empty;
text = FillText(text, wordCount);
Console.WriteLine(PrintText(text));
Console.WriteLine();
string newText = DelNumber(text);
Console.WriteLine(PrintText(newText));
