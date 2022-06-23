// See https://aka.ms/new-console-template for more information
String[] piatti = { "Carbonara", "Braciola", "Pollo allo spiedo", "Insalata", "Hamburger", "Risotto" };

//Stampo la lunghezza della classifica
Console.WriteLine("La classifica dei miei piatti preferiti è composta da " + piatti.Length + " elementi");

//Stampo la  classifica in ordine indicando la posizione in classifica
int i = 0;
for (; i < piatti.Length; i++)
{
    Console.WriteLine("Alla posizione " + i + " " + piatti[i]);
}

//Stampo il mio piatto preferito
Console.WriteLine("Il mio piatto preferito è " + piatti[0]);

//Stampo il piatto che preferisco di meno
string last = piatti[piatti.Length - 1];
Console.WriteLine("Il piatto che preferisco di meno " + last);


