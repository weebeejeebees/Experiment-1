double inc = 0.0218;
int a = 1949400; //2023 population


double constant = a * inc;  //2.18% of  2023 population
int constInt = Convert.ToInt32(constant);

int b = a + constInt; //2024 

int c = b + constInt; //2025

int d = c + constInt; //2026

int e = d + constInt; //2027

int f = e + constInt; //2028



Console.WriteLine("Davao City Estimated Population in the Next Five Years");
Console.WriteLine("Year                 Estimated Population");


Console.WriteLine("2024                 " + b);
Console.WriteLine("2025                 " + c);
Console.WriteLine("2026                 " + d);
Console.WriteLine("2027                 " + e);
Console.WriteLine("2028                 " + f);
