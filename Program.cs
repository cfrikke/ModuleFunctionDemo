    Console.Clear();
    Console.WriteLine("Please input your name.");
    string n;
    n = Console.ReadLine();
    GreetUser(n);


static void GreetUser(string Name){
    Console.WriteLine("Hello " + Name + ".");
}