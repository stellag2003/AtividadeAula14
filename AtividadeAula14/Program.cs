// See https://aka.ms/new-console-template for more information
using AtividadeAula14;


Cliente c1 = new("Rihanna", "rihanna@gmail.com", "123", 1500, true, true);

Cliente c2 = new("Beyoncé", "beyonce@gmail.com", "321", 2850.99, false, false);

c1.mostra();
c1.contaBancaria.mostra();

c2.mostra();
c2.contaBancaria.mostra();

Console.ReadLine();







