Console.WriteLine("Ingrese una ecuación simple (por ejemplo, 582+2):");
string ecuacion = Console.ReadLine();
string[] partes = ecuacion.Split(new char[] { '+', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
double num1_ecuacion = double.Parse(partes[0]);
double num2_ecuacion = double.Parse(partes[1]);
double resultado_ecuacion = 0;

string operador = new string(ecuacion.Except(partes[0]).Except(partes[1]).ToArray()).Trim();

switch (operador)
{
    case "+":
        resultado_ecuacion = num1_ecuacion + num2_ecuacion;
        break;
    case "-":
        resultado_ecuacion = num1_ecuacion - num2_ecuacion;
        break;
    case "":
        resultado_ecuacion = num1_ecuacion * num2_ecuacion;
        break;
    case "/":
        resultado_ecuacion = num1_ecuacion / num2_ecuacion;
        break;
    default:
        Console.WriteLine("Ecuación no válida.");
        break;
}
