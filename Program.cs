// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// public class Palindromo {
Boolean PalindromoValidation(string word)
{
    string palabra = word;
    char[] chars = word.ToCharArray();
    Array.Reverse(chars);
    string cadenaInvertida = new String(chars);
    return palabra == cadenaInvertida;
}
Boolean PalindromoValidation3(string word)
{
    string palabra = word;
    char[] wordChar = word.Reverse().ToArray();
    string cadenaInvertida1 = new String(wordChar);
    return palabra == cadenaInvertida1;
}
Boolean PalindromoValidation4(string word)
{
    return word.SequenceEqual(word.Reverse());
}
Boolean PalindromoValidation2(string word)
{
    string palabra = word;
    string cadenaInvertida2 = "";
    foreach (char letra in word)
    {
        cadenaInvertida2 = letra + cadenaInvertida2;
    }
    return palabra == cadenaInvertida2;
}

String PalindromoMasLargo(String word)
{
    String palindromoMasLargo = "";
    int n = 0;
    while (n < word.ToCharArray().Length)
    {
        for (int i = 1; i <= word.ToCharArray().Length - n; i++)
        {
            string palabraDeTurno = word.Substring(n, i);

            if (PalindromoValidation4(palabraDeTurno) && palindromoMasLargo.ToArray().Length < palabraDeTurno.ToArray().Length)
                palindromoMasLargo = palabraDeTurno;
        }
        n++;
    }
    return palindromoMasLargo;
}

// }

Console.WriteLine(PalindromoValidation("aoa"));
Console.WriteLine(PalindromoValidation2("aoa"));
Console.WriteLine(PalindromoValidation3("aoa"));
Console.WriteLine(PalindromoValidation4("aoa"));
Console.WriteLine(PalindromoMasLargo("12345654321"));
