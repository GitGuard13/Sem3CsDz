// Задача №19

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n > 9999 && n < 100000)    
// {
//     int N5 = (n % 10);
//     int N1 = (n / 10000);
//     int N4 = ((n / 10) % 10);
//     int N2 = ((n % 10000) / 1000);
//     {
//         if ((N5 == N1) && (N4 == N2))
//         {
//             Console.WriteLine($"{n} -> палиндром");
//         }
//         else
//         {   
//             Console.WriteLine($"{n} -> не палиндром");
//         }
//     }
// }
// else 
// {
//     Console.WriteLine($"{n} -> НЕ верное число");
// }   

// Задача №21

// Console.Write("Введите X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);

// Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {d})");

// Задача №23

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }