//using System;

//int numero1 = 0;
//int numero2 = 0;


//Console.WriteLine("Ingresar el primero numero");
//numero1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ingresar el segundo numero");
//numero2 = Convert.ToInt32(Console.ReadLine());

//if (numero1 > numero2)
//{
//    Console.WriteLine("El numero mayor es: " + numero1);
//}
//else
//{
//    Console.WriteLine("El numero mayor es: " + numero2);
//}



//int numero = 0;
//Console.WriteLine("Ingresar un numero");
//numero = Convert.ToInt32(Console.ReadLine());

//if (numero % 2 == 0)
//{
//    Console.WriteLine("El numero es par");
//}
//else
//{
//    Console.WriteLine("El numero es impar");
//}







//int calificacion = 0;

//Console.WriteLine("Ingresar calificacion:");
//calificacion = Convert.ToInt32(Console.ReadLine());


//if (calificacion >= 90 && calificacion <= 100)
//{
//    Console.WriteLine("Excelente");
//}
//else if (calificacion >= 80 && calificacion <= 89)
//{
//    Console.WriteLine("Muy Bueno");
//}
//else if (calificacion >= 70 && calificacion <= 79)
//{
//    Console.WriteLine("Bueno");
//}
//else if (calificacion >= 60 && calificacion <= 69)
//{
//    Console.WriteLine("Suficiente");
//}
//else
//{
//    Console.WriteLine("Insuficiente");
//}



//int dia = 0;

//Console.WriteLine("Ingresar el dia de la semana");
//dia = Convert.ToInt32(Console.ReadLine());

//if(1 == dia)
//{
//    Console.WriteLine("Lunes");
//}
//if (2 == dia)
//{
//    Console.WriteLine("Martes");
//}
//if (3 == dia)
//{
//    Console.WriteLine("Miercoles");
//}
//if (4 == dia)
//{
//    Console.WriteLine("Jueves");
//}
//if (5 == dia)
//{
//    Console.WriteLine("Viernes");
//}
//if (6 == dia)
//{
//    Console.WriteLine("Sabado");
//}
//if (7 == dia)
//{
//    Console.WriteLine("Domingo");
//}


//int meseDelAnio = 0;
//string mes = "";


//Console.WriteLine("Ingresar el mes del año:");
//meseDelAnio = Convert.ToInt32(Console.ReadLine());

//switch ( meseDelAnio)
//{
//    case 1:
//        mes = "Enero";
//        break;
//    case 2:
//        mes = "Febrero";
//        break;
//    case 3:
//        mes = "Marzo";
//        break;
//    case 4:
//        mes = "Abril";
//        break;
//    case 5:
//        mes = "Mayo";
//        break;
//    case 6:
//        mes = "Junio";
//        break;
//    case 7:
//        mes = "Julio";
//        break;
//    case 8:
//        mes = "Agosto";
//        break;
//    case 9:
//        mes = "Setiembre";
//        break;
//    case 10:
//        mes = "Octubre";
//        break;
//    case 11:
//        mes = "Noviembre";
//        break;
//    case 12:
//        mes = "Diciembre";
//        break;

//    default:
//        mes = "Numero incorrecto";
//        break;
//}

//Console.WriteLine("El mes es " + mes);

//int meseDelAnio = 0;



//Console.WriteLine("Ingresar el mes del año:");
//meseDelAnio = Convert.ToInt32(Console.ReadLine());

//switch (meseDelAnio)
//{
//    case 1:
//        Console.WriteLine("Verano");
//        break;
//    case 2:
//        Console.WriteLine("Verano");
//        break;
//    case 3:
//        Console.WriteLine("Verano");
//        break;
//    case 4:
//        Console.WriteLine("Otoño");
//        break;
//    case 5:
//        Console.WriteLine("Otoño");
//        break;
//    case 6:
//        Console.WriteLine("Otoño");
//        break;
//    case 7:
//        Console.WriteLine("Invierno");
//        break;
//    case 8:
//        Console.WriteLine("Invierno");
//        break;
//    case 9:
//        Console.WriteLine("Invierno");
//        break;
//    case 10:
//        Console.WriteLine("Primavera");
//        break;
//    case 11:
//        Console.WriteLine("Primavera");
//        break;
//    case 12:
//        Console.WriteLine("Primavera");
//        break;
//     default: 
//        Console.WriteLine("Mes incorrecto");
//        break;
//}



int opciones  = 0;
int area = 0;
int volumen = 0;
int lado = 0;
Console.WriteLine("Ingresar la opcion:");
Console.WriteLine("1. Calcular area del cuadrado");
Console.WriteLine("2. Calcular volumen del cubo");
Console.WriteLine("3. Salir");
opciones = Convert.ToInt32(Console.ReadLine());

switch (opciones)
{
    case 1:
        Console.WriteLine("Ingresar el lado del cuadrado");
        lado = Convert.ToInt32(Console.ReadLine());
        area = lado * lado;
        Console.WriteLine("El resultado del area del cuadrado es: "+ area);
        break;
    case 2:
        Console.WriteLine("Ingresar el lado del cubo");
        lado = Convert.ToInt32(Console.ReadLine());
        volumen = lado * lado * lado;
        Console.WriteLine("El resultado del volumen del cubo es: " + volumen);
        break; 
    case 3:
        Console.WriteLine("Ha salido de la aplicacion");
            break;
    default:
        Console.WriteLine("Opcion incorrecta");
        break;
}