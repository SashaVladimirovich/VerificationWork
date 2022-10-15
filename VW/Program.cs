Console.Clear();
string FillText(string text, int wordCount)
{
    string librarySymbol = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";//библиотека символов

    for (int i = 0; i < wordCount; i++)
    {
        string word = String.Empty;
        int wordLength = new Random().Next(1, 15); //рандомна длина слова
        for (int j = 0; j < wordLength; j++)
        {
            word = word + librarySymbol[new Random().Next(0, 62)]; //сбор слова из символов
        }
        text += word + " ";
    }
    return text;
}
string PrintText(string text)
{
    return "|" + String.Join(' ', text) + "|";
}

int wordCount = new Random().Next(2, 30);//рандомное количество слов

string text = String.Empty;
text = FillText(text, wordCount);
Console.WriteLine(PrintText(text));
