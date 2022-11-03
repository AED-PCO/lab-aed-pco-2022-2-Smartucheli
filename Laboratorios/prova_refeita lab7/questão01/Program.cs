using System;
using System.IO;

int l_igual = 0, l_diferente = 0;
string texto;

Console.Write("Digite um texto: ");
texto = Console.ReadLine();

var file = File.ReadAllLines("arq1.txt");

while(texto != ""){
    if(texto == file){
        Console.WriteLine("igual");
        l_igual++;
    } else {
        Console.Write("Diferente");
        l_diferente++;
    }
}

