namespace ExercicioAvl
{
    public static class Program
    {
        public static void Main()
        {
            var tree = new WorkNode();

            while (true)
            {
                Console.WriteLine("=================");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Exibir");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("=================");
                Console.Write("> ");

                var op = Console.ReadLine();
                if (op == "0") break;

                switch (op)
                {
                    case "1":
                        while (true)
                        {
                            Console.Write("Valor para inserir (Enter vazio ou 'v' para voltar): ");
                            var txt = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(txt) ||
                                txt.Equals("v", StringComparison.OrdinalIgnoreCase))
                                break;

                            if (int.TryParse(txt, out var v))
                            {
                                tree.Insert(v);
                                Console.WriteLine($"Inserido: {v}");
                            }
                            else
                                Console.WriteLine("Valor inválido. Digite um inteiro.");
                        }
                        break;
                    case "2":
                        Console.Write("Valor para remover: ");
                        if (int.TryParse(Console.ReadLine(), out var r))
                            tree.Remove(r);
                        break;

                    case "3":
                        PrintNode.Print(tree);
                        break;
                }
            }
        }
    }
}
