string hello = "we are the campions?";

int stringLenght = hello.Length;

//string trimmedString = hello, Trim();


hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);

//int wordCounter = 1
//for(int i = 0; i < hello.Lenght; i++)
//{
//    if (char.IsWhiteSpace(hello[i])))
//    {
//        wordCounter++;
//    }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");
