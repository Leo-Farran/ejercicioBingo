Random aleatorio = new Random();

// Se declaran tres vectores correspondiente a cada fila del carton
int[] vector1 = new int[9];
int[] vector2 = new int[9];
int[] vector3 = new int[9];

// Se declaran dos variables auxiliares: 
int aux; // para asignarle un valor aleatorio, de la decena correspondiente a la columna que se esta iterando
int aux2; // se utiliza en el proceso de hacer aleatoria la posicion a ocupar dentro del vector
int contador = 0;

do
{
    for (int i = 0; i < 9; i++)
    {
        aux2 = aleatorio.Next(1, 3);
        if (contador < 5) // Cantidad de numeros por fila
        {
            if (aux2 == 1) // Controla el valor cada vuelta del for, mientras i suma en 1 a veces aux sera 1. Le da aletoriedad a la posicion.
            {

                if (vector1[i] == 0) // Si aun no hay un valor en la posicion de i aun
                {
                    contador++; // Por cada vuelta que aux2 == 1 suma el contador en 1
                    switch (i) // Dependiendo la posicion de i el case correspondiente, se asigna la decena aleatoria 
                    {
                        case 0:
                            vector1[i] = aleatorio.Next(1, 9);
                            break;

                        case 1:
                            vector1[i] = aleatorio.Next(10, 20);
                            break;

                        case 2:
                            vector1[i] = aleatorio.Next(20, 30);
                            break;

                        case 3:
                            vector1[i] = aleatorio.Next(30, 40);
                            break;

                        case 4:
                            vector1[i] = aleatorio.Next(40, 50);
                            break;

                        case 5:
                            vector1[i] = aleatorio.Next(50, 60);
                            break;

                        case 6:
                            vector1[i] = aleatorio.Next(60, 70);
                            break;

                        case 7:
                            vector1[i] = aleatorio.Next(70, 80);
                            break;

                        default:
                            vector1[i] = aleatorio.Next(80, 91);
                            break;


                    }
                }
            }

        }
        else
        {
            break;
        }
    }
} while (contador < 5); // Repite hasta que se cuenten los 5 numeros por fila

contador = 0; // Volvemos a inicializar el contador en 0 para repetir proceso para el siguiente vector

do
{
    for (int i = 0; i < 9; i++)
    {
        aux2 = aleatorio.Next(1, 3);
        if (contador < 5)
        {
            if (aux2 == 1)
            {
                if (vector2[i] == 0) // En caso que la fila 2 no tenga un numero aun
                    switch (i)
                    {
                        case 0:
                            aux = aleatorio.Next(1, 9);
                            if (aux != vector1[i] && aux > vector1[i]) // Controla que no se repita el numero con respecto a la misma posicion en vector1
                            {
                                vector2[i] = aux; // asigna el valor
                                contador++; //cuenta un numero de fila
                            }
                            break;

                        case 1:
                            aux = aleatorio.Next(10, 20);
                            if (aux != vector1[i] && aux > vector1[i])
                            {
                                vector2[i] = aux;
                                contador++;
                            }
                            break;

                        case 2:
                            aux = aleatorio.Next(20, 30);
                            if (aux != vector1[i] && aux > vector1[i])
                            {
                                vector2[i] = aux;
                                contador++;
                            }
                            break;

                        case 3:
                            aux = aleatorio.Next(30, 40);
                            if (aux != vector1[i] && aux > vector1[i])
                            {
                                vector2[i] = aux;
                                contador++;
                            }
                            break;

                        case 4:
                            aux = aleatorio.Next(40, 50);
                            if (aux != vector1[i] && aux > vector1[i])
                            {
                                vector2[i] = aux;
                                contador++;
                            }
                            break;

                        case 5:
                            aux = aleatorio.Next(50, 60);
                            if (aux != vector1[i] && aux > vector1[i])
                            {
                                vector2[i] = aux;
                                contador++;
                            }
                            break;

                        case 6:
                            aux = aleatorio.Next(60, 70);
                            if (aux != vector1[i] && aux > vector1[i])
                            {
                                vector2[i] = aux;
                                contador++;
                            }
                            break;

                        case 7:
                            aux = aleatorio.Next(70, 80);
                            if (aux != vector1[i] && aux > vector1[i])
                            {
                                vector2[i] = aux;
                                contador++;
                            }
                            break;

                        default:
                            aux = aleatorio.Next(80, 91);
                            if (aux != vector1[i] && aux > vector1[i])
                            {
                                vector2[i] = aux;
                                contador++;
                            }
                            break;
                    }
            }
        }
        else
        {
            break;
        }
    }
} while (contador < 5); // repite hasta que consigue 5 numeros por fila

contador = 0;

// Este for itera 9 veces controlando una sola vez por posicion los valores de vector 1 y 2
for (int i = 0; i < 9; i++)
{
    if(contador < 5)
    {
        if (vector1[i] == 0 && vector2[i]==0) // En caso que el valor de la misma posicion en los vectores 1 y 2 sea 0, agrega numero en vector 3
        {
            contador++;  
            switch(i)
            {
                case 0:
                    vector3[i] = aleatorio.Next(1, 10);
                    break;

                case 1:
                    vector3[i] = aleatorio.Next(10, 20);
                    break;

                case 2:
                    vector3[i] = aleatorio.Next(20, 30);
                    break;

                case 3:
                    vector3[i] = aleatorio.Next(30, 40);
                    break;

                case 4:
                    vector3[i] = aleatorio.Next(40, 50);
                    break;

                case 5:
                    vector3[i] = aleatorio.Next(50, 60);
                    break;

                case 6:
                    vector3[i] = aleatorio.Next(60, 70);
                    break;

                case 7:
                    vector3[i] = aleatorio.Next(70, 80);
                    break;

                default:
                    vector3[i] = aleatorio.Next(80, 91);
                    break;
            }        
        }      
    }
    else
    {
        break;
    }
}

do
{
    for (int i = 0; i < 9; i++)
    {
        aux = aleatorio.Next(1, 3);

        if (contador < 5)
        {
            if (vector1[i] == 0 || vector2[i] == 0) // Condicion que controla si ya hay numero en vector1 o en vector2
            {
                if (aux == 1)
                {
                    if (vector3[i] == 0) // En caso que todavia la tercer fila no tenga un numero y vector1 o vector2 no tenga un numero en la misma fila
                    {
                        switch (i)
                        {
                            case 0:
                                aux2 = aleatorio.Next(1, 10);
                                if (aux2 != vector1[i] && aux2 != vector2[i] && aux2 > vector1[i] && aux2 > vector2[i]) // Controla que aux2 sea distinto en la misma posicion de vector1 y vectory ademas mayor a los mismos
                                {
                                    vector3[i] = aux2;
                                    contador++;
                                }
                                break;

                            case 1:
                                aux2 = aleatorio.Next(10, 20);
                                if (aux2 != vector1[i] && aux2 != vector2[i] && aux2 > vector1[i] && aux2 > vector2[i])
                                {
                                    vector3[i] = aux2;
                                    contador++;
                                }
                                break;

                            case 2:
                                aux2 = aleatorio.Next(20, 30);
                                if (aux2 != vector1[i] && aux2 != vector2[i] && aux2 > vector1[i] && aux2 > vector2[i])
                                {
                                    vector3[i] = aux2;
                                    contador++;
                                }
                                break;

                            case 3:
                                aux2 = aleatorio.Next(30, 40);
                                if (aux2 != vector1[i] && aux2 != vector2[i] && aux2 > vector1[i] && aux2 > vector2[i])
                                {
                                    vector3[i] = aux2;
                                    contador++;
                                }
                                break;

                            case 4:
                                aux2 = aleatorio.Next(40, 50);
                                if (aux2 != vector1[i] && aux2 != vector2[i] && aux2 > vector1[i] && aux2 > vector2[i])
                                {
                                    vector3[i] = aux2;
                                    contador++;
                                }
                                break;

                            case 5:
                                aux2 = aleatorio.Next(50, 60);
                                if (aux2 != vector1[i] && aux2 != vector2[i] && aux2 > vector1[i] && aux2 > vector2[i])
                                {
                                    vector3[i] = aux2;
                                    contador++;
                                }
                                break;

                            case 6:
                                aux2 = aleatorio.Next(60, 70);
                                if (aux2 != vector1[i] && aux2 != vector2[i] && aux2 > vector1[i] && aux2 > vector2[i])
                                {
                                    vector3[i] = aux2;
                                    contador++;
                                }
                                break;

                            case 7:
                                aux2 = aleatorio.Next(70, 80);
                                if (aux2 != vector1[i] && aux2 != vector2[i] && aux2 > vector1[i] && aux2 > vector2[i])
                                {
                                    vector3[i] = aux2;
                                    contador++;
                                }
                                break;

                            default:
                                aux2 = aleatorio.Next(80, 91);
                                if (aux2 != vector1[i] && aux2 != vector2[i] && aux2 > vector1[i] && aux2 > vector2[i])
                                {
                                    vector3[i] = aux2;
                                    contador++;
                                }
                                break;
                        }
                    }
                }
            }
        }
        else
        {
            break;
        }
    }
} while (contador < 5);

for (int i = 0; i < 9; i++)
{
    if (vector1[i] == 0)
    {
        Console.Write($"{(vector1[i] == 0 ? "  |" : " ")}"); // Si hay 0 en la posicion, imprime dos espacio vacio + |
    }
    else
    {
        Console.Write(vector1[i].ToString("00") + "|"); // Convierte a un string el valor del vector + |, el formato del strig es "00", solamente por estetica
    }
}
Console.WriteLine();

for (int i = 0; i < 9; i++)
{
    if (vector2[i] == 0)
    {
        Console.Write($"{(vector2[i] == 0 ? "  |" : " ")}");
    }
    else
    {
        Console.Write(vector2[i].ToString("00") + "|");
    }
}
Console.WriteLine();

for (int i = 0; i < 9; i++)
{
    if (vector3[i] == 0)
    {
        Console.Write($"{(vector3[i] == 0 ? "  |" : " ")}"); 
    }
    else
    {
        Console.Write(vector3[i].ToString("00") + "|"); 
    }
}
Console.WriteLine();

