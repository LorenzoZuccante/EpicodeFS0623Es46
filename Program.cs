using System;
using System.Security.Cryptography.X509Certificates;

namespace Esercizio46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizo 46");
            Atleta Giorgio = new Atleta();
            Giorgio.Greet();
            Giorgio.HowMuchTo200();
            Giorgio.Result();
            Dipendente Alfonso = new Dipendente();
            Alfonso.Greet();
            Alfonso.ChangeName();
            Alfonso.Greet();
            Animale Chullo = new Animale();
            Chullo.Greet();
            Chullo.StampaEtaUmana();
            Veicolo Porsche = new Veicolo();
            Porsche.PresentazioneModello();
            
        }
    }
}

class Atleta
{
    public string Name = "Giorgio";
    public string Surname = "Almare";
    public int Height = 172;
    public int weight = 60;
    public string Sport = "Padel";
    public int ChampionshipPoints = 223;

    public void Greet()
    {
        Console.WriteLine("L'atleta " + Name +" "+ Surname + ",nel campionato di " + Sport + " ha conseguito un punteggio di " + ChampionshipPoints);
    }
    public int HowMuchTo200()
    {
        return 200 - Height;
    }
    public void Result()
    {
        Console.WriteLine("To reach 200cm miss" + HowMuchTo200() +" cm");
    }

}
class Dipendente
{
    public string Name = "Alfonso";
    public string Company = "Epicode";
    public string JobType = "Developer";

    public void Greet()
    {
        Console.WriteLine(" Hi, my name is " + Name + " i study from " + Company + " and my dreamwork is the web " + JobType);
    }

    public string ChangeName()
    {
        return Name = "Dario";
    }
}

class Animale
{
    public string Name = "Chullo";
    public string Race = "Cat";
    public string SubRace = "European";
    public string FurColor = "black, white and Brown";
    public int Age = 6;
    public int Weight = 5;

    public void Greet()
    {
        Console.WriteLine("Hi, i'm Lorenzo's cat my name is " + Name + ", my subrace is " + SubRace + "and my fur color is " + FurColor);
    }

    public int CalcolaAnniUmaniDelGatto(int etaGatto)
    {
        if (etaGatto <= 0)
        {
            return 0;
        }
        else if (etaGatto == 1)
        {
            return 15;
        }
        else if (etaGatto == 2)
        {
            return 24;
        }
        else
        {
            return 24 + (etaGatto - 2) * 4;
        }
    }

    public void StampaEtaUmana()
    {
        int etaUmanaDelGatto = CalcolaAnniUmaniDelGatto(Age);
        Console.WriteLine($"L'età umana del gatto di {Age} anni è: {etaUmanaDelGatto} anni");
    }
}
class Veicolo
{
    public string Marca = "Porsche";
    public string Modello = "911";
    public int Potenza = 700;
    public int VelocitaMax = 315;
    public int Coppia = 650;
    public string Colore = "rosso acceso";

    public void PresentazioneModello()
    {
        Console.WriteLine($"Ecco a te la tua {Marca} {Modello} {Colore} con {Potenza} cv, {Coppia} n/m di coppia che raggiunge una velocità massima di {VelocitaMax} km/h!");
    }

}
