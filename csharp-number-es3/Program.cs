// dichiaro la variabile age di tipo intero
int age;
// chiedo all'utente di inserire la sua età
Console.WriteLine("Inserisci la tua età:");
// leggo l'input dell'utente e lo converto in intero
int.TryParse(Console.ReadLine(), out age);
// se ha meno di 18 anni
if (age < 18)
{
    Console.WriteLine("Sei troppo giovane per accedere a questo sito web.");
}
else // altrimenti
{
    Console.WriteLine("Benvenuto nel sito web!");
}
