
Console.WriteLine("ingresá la cantidad de filas"); //paso2
int filas = int.Parse(Console.ReadLine());
Console.WriteLine("ingresá la cantidad de columnas");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas]; //paso1

for (int fila = 0; fila <= matriz.GetUpperBound(0); fila++)
{
    for (int columna = 0; columna <= matriz.GetUpperBound(1); columna++) //paso5
    {
        Console.WriteLine($"ingresar un número: {fila}, columna {columna}");
        int numero = int.Parse(Console.ReadLine());
        matriz[fila,columna] = numero;
    }
}

//mostramos la matriz
for (int fila = 0; fila <= matriz.GetUpperBound(0); fila++) //paso5
{
    for (int columna = 0; columna <= matriz.GetUpperBound(1); columna++)
    {
        Console.Write("[" + matriz[fila,columna] + "] ");

    }
    Console.WriteLine();
}
Console.WriteLine();

int cantNumFila = matriz.GetUpperBound(0)+1;
int cantNumCol = matriz.GetUpperBound(1)+1; 

double[] promedio = new double[cantNumCol]; //paso3

for (int columna = 0; columna <= matriz.GetUpperBound(1); columna++) //paso5
{
    for (int fila = 0; fila <= matriz.GetUpperBound(0); fila++)
    {
        promedio[columna] = promedio[columna] + matriz[fila,columna];
        Console.Write("[" + matriz[fila,columna] + "] ");

    }
    promedio[columna] = promedio[columna]/cantNumFila;
    Console.WriteLine();
}
foreach (var promedioCol in promedio)
{
    Console.Write(promedioCol+ " ");
}
