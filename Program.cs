Console.Clear();

double glicemia; 

Console.Write(@"  --- TESTE DE DIABETES GESTACIONAL ---

Insira o valor do seu teste de glicemia -> ");
glicemia = Convert.ToDouble (Console.ReadLine ());

if (glicemia > 70 && glicemia < 92) 
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine ("Você está bem! :) Reavalie entre 24 e 28 semanas com TTOG 75g de glicose enquanto ainda estiver grávida");
} 

else if (glicemia > 92 && glicemia < 126) 
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Você tem Diabetes Gestacional :/");
}

else if (glicemia > 126) 
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine ("Você tem Diabetes Mellitus na Gravidez :(");
}

//BÔNUS

else if (glicemia > 10 && glicemia < 70) 
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine ("Você tem deficiência de glicose, procure tratamento imediato ºoº");
}

else if (glicemia <= 10) 
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Diga adeus aos amigos e à família. Você já deve estar morta antes mesmo desse teste acabar x ¬ x");
}

Console.WriteLine();
Console.ResetColor();

//Nicolas e Breno :¬)