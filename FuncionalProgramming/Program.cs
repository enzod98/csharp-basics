
Operation mySum = Functions.Sum;
mySum = Functions.Mul;

Console.WriteLine(mySum(2,3));


Show show = Functions.ConsoleShow;
show("Hola mundo");

Show cw = Console.WriteLine;
cw += Functions.ConsoleShow;
//cw("Hola mundo desde CW");
//Functions.Some("enzo", "duré", cw);


#region Action
//Cuando hacemos delegados que reciben parámetros del mismo tipo y no retornan nada, usamos Action
Action<string> ShowMessage = Console.WriteLine;
Action<string, string> ShowMessage2 = (a, b) => Console.WriteLine($"{a}, {b}");
//ShowMessage2("enzo", "dure");
//ShowMessage("hola");
//Functions.SomeAction("enzo", "duré", ShowMessage);
//Functions.SomeAction("enzo", "duré", (a) => Console.WriteLine("Soy una expresión Lambda de " + a));

#endregion

#region Func
//Cuando hacemos delegados que retornan algo, entonces usamos Func
Func<int> numberRandom = () => new Random().Next(0,100);
Func<int, int> numberRandom2 = (a) => new Random().Next(0, a);
// El último tipo de variable que definamos en el <> es lo que vamos a retornar, lo que está antes son los parámetros

//Console.WriteLine(numberRandom());
//Console.WriteLine(numberRandom2(10));

#endregion

#region Predicate
//Reciben un parámetro y devuelven un valor booleano
Predicate<string> tieneEspacioOLetraA = (a) => a.Contains(" ") || a.ToUpper().Contains("A");
Console.WriteLine(tieneEspacioOLetraA("asdasd"));
var words = new List<string>()
{
    "hola",
    "gente",
    "si", 
    "hola que tal"
};

var wordsNew = words.FindAll(tieneEspacioOLetraA);
var wordsNewLambda = words.FindAll((w) => tieneEspacioOLetraA(w));

foreach (var word in wordsNew) Console.WriteLine(word);
#endregion

#region Delegados
public delegate int Operation(int a, int b);
public delegate void Show(string mensaje);
public delegate void Show2(string mensaje, string message2);
#endregion

public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int x, int y) => x * y;
    public static void ConsoleShow(string mensaje) => Console.WriteLine(mensaje.ToUpper());
    public static void Some(string name, string lastName, Show show)
    {
        Console.WriteLine("Hago algo primero");
        show($"Nombre: {name}, Apellido: {lastName}");
        Console.WriteLine("Hago algo al final");
    }

    public static void SomeAction(string name, string lastName, Action<string> show)
    {
        Console.WriteLine("Hago algo primero");
        show($"Nombre: {name}, Apellido: {lastName}");
        Console.WriteLine("Hago algo al final");
    }

}
