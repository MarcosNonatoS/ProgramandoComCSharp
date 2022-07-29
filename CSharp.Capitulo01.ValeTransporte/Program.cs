
Inicio:

Console.WriteLine("Informe o Nome: ");
var nomeUsuario = Console.ReadLine();

Console.WriteLine("Informe o Salário: ");
var salarioUsuario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe o VT: ");
var valeTransporte = Convert.ToDecimal(Console.ReadLine());

var descontoMaximo = salarioUsuario * 6/100;

var descontoVT = valeTransporte > descontoMaximo ? descontoMaximo : valeTransporte;

Console.WriteLine($"O Funcionário {nomeUsuario} com salário {salarioUsuario}, terá um desconto de {descontoVT}");

Console.WriteLine("\nPressiona ESC para sair ou Enter para um novo cálculo.");

var teclaPressionada = Console.ReadKey();

if (teclaPressionada.Key==ConsoleKey.Escape)
{
    Environment.Exit(0);
};

Console.Clear();

goto Inicio;