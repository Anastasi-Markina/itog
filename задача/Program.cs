            string[] array;
            Console.WriteLine("Введите массив через пробел");
            string stroka = Console.ReadLine();
            array = stroka.Split(' ');
            var result = new string[array .Length];
            var size = 0;
            foreach (var value in array )
            {
                if (value.Length <= 3)
                {
                    result[size] = value;
                    size++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, size));
            Console.ReadKey(true);