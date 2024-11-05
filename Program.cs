
Para teste o código primeiramente apague esse texto e no código que deseja testar selecione e use o seguinte atalho 
CTRL + U e ´para comentar CTRL + K + C 

//Ex 1 Resposta
//class Fibonacci
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Informe um número: ");
//        int numero = int.Parse(Console.ReadLine());

//        List<int> sequencia = GerarSequenciaFibonacci(numero);

//        if (sequencia.Contains(numero))
//        {
//            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
//            Console.WriteLine($"Sequência de Fibonacci até o número informado {numero}:");
//            foreach (var num in sequencia)
//            {
//                Console.Write(num + " ");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
//        }
//    }

//    static List<int> GerarSequenciaFibonacci(int limite)
//    {
//        List<int> sequencia = new List<int> { 0, 1 };
//        int a = 0;
//        int b = 1;

//        while (true)
//        {
//            int c = a + b;
//            if (c > limite)
//            {
//                break;
//            }
//            sequencia.Add(c);
//            a = b;
//            b = c;
//        }

//        return sequencia;
//    }
//}


//Ex 2  Resposta

//class EncontraString
//{
//    static void Main()
//    {
//        // Solicitar a entrada da string do usuário
//        Console.Write("Informe uma string: ");
//        string input = Console.ReadLine();

//        // Verificar a existência da letra 'a' e contar as ocorrências
//        int countMin = ContarOcorrenciasDeA(input, 'a');
//        int countMai = ContarOcorrenciasDeA(input, 'A');

//        if (countMin > 0)
//        {
//            Console.WriteLine($"A letra 'a' (minúscula) ocorre {countMin} vezes na string informada.");
//        }

//        if (countMai > 0)
//        {
//            Console.WriteLine($"A letra 'A' (maiúscula) ocorre {countMai} vezes na string informada.");
//        }

//        if (countMin == 0 && countMai == 0)
//        {
//            Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não ocorre na string informada.");
//        }
//    }

//    static int ContarOcorrenciasDeA(string input, char letra)
//    {
//        int count = 0;
//        foreach (char c in input)
//        {
//            if (c == letra)
//            {
//                count++;
//            }
//        }
//        return count;
//    }
//}

//Ex 3  Resposta

//class Soma 
//{ static void Main() { int INDICE = 12; 
//    int SOMA = 0; int K = 1;
//    while (K < INDICE) { K = K + 1; SOMA = SOMA + K; }
//    Console.WriteLine("O valor da variável SOMA é: " + SOMA); } 
//}
