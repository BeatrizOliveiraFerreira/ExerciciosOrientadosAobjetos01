using ExerciciosOrientadosAobjetos01;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            PessoaMaisVelha a, b;

            a = new PessoaMaisVelha();
            b = new PessoaMaisVelha();

            a.nome1 = Console.ReadLine();
            b.idade1 = int.Parse(Console.ReadLine());
            a.nome2 = Console.ReadLine();
            b.idade2 = int.Parse(Console.ReadLine());

            if (b.idade1 > b.idade2 ) {
                Console.WriteLine($"Pessoa mais velha: {a.nome1}");
            }
            else {
                Console.WriteLine($"Pessoa mais velha: {a.nome2}");
            }

        }
    }
}
