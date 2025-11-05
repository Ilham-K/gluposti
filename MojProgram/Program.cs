/* Upustvo za upotrebu: U slučaju da želite provjeriti tačnost koda dovoljno je da izbrisete znakove za komentarisanje te nakon toga možete pokrenuti kod u terminalu. */

/* Zadatak 1: Ispis poruke

Tekst zadatka:

Napisati program koji ispisuje poruku “Dobrodošli u svijet programiranja!”.

Kod: */

/* using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Dobrodošli u svijet programiranja!");
    }
} */

/* Objašnjenje:

Program koristi Console.WriteLine() za ispis teksta na ekran. */

/* Zadatak 2: Ispis imena korisnika

Tekst zadatka:

Program treba omogućiti korisniku da unese svoje ime i zatim ispiše poruku “Zdravo, [ime]!”.

Kod: */
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite vaše ime: ");
        string ime = Console.ReadLine();
        Console.WriteLine("Zdravo, " + ime + "!");
    }
} */

/* Objašnjenje:

Koristi se Console.ReadLine() za unos, a zatim slijedi ispis. */

/* Zadatak 3: Sabiranje dva broja

Tekst zadatka:

Program treba omogućiti unos dva broja i ispisati njihov zbir.

Kod: */

/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite prvi broj: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Unesite drugi broj: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Zbir je: " + (a + b));
    }
} */

/* Objašnjenje:

Koriste se varijable tipa int i operator + za sabiranje. */

/* Zadatak 4: Provjera parnosti broja

Tekst zadatka:

Korisnik unosi broj te program provjerava da li je paran ili neparan.

Kod: */

/* using System;

class Program
{
   static void Main()
   {
       Console.Write("Unesite broj: ");
       int broj = int.Parse(Console.ReadLine());

       if (broj % 2 == 0)
           Console.WriteLine("Broj je paran.");
       else
           Console.WriteLine("Broj je neparan.");
   }
} */

/* Objašnjenje:

Operator % računa ostatak pri dijeljenju. Ako je ostatak 0, broj je paran. */

/* Zadatak 5: Najveći od tri broja

Tekst zadatka:

Unose se tri broja i program ispisuje koji je najveći.

Kod: */

/* using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite tri broja:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int max = a;

        if (b > max) max = b;
        if (c > max) max = c;

        Console.WriteLine("Najveći broj je: " + max);
    }
} */

/* Objašnjenje:

Korištenjem if uslova pronalazi se maksimalna vrijednost među tri broja. */

/* Zadatak 6: Sabiranje n brojeva pomoću petlje

Tekst zadatka:

Unosi se broj n, a zatim n brojeva. Program ispisuje njihov zbir.

Kod: */

/* using System;

class Program
{
   static void Main()
   {
       Console.Write("Koliko brojeva želite unijeti? ");
       int n = int.Parse(Console.ReadLine());
       int suma = 0;

       for (int i = 1; i <= n; i++)
       {
           Console.Write($"Unesite broj {i}: ");
           suma += int.Parse(Console.ReadLine());
       }

       Console.WriteLine("Zbir svih brojeva je: " + suma);
   }
} */

/* Objašnjenje:

For petlja se koristi za višestruki unos i akumulaciju sume.*/

/* Zadatak 7: Tablica množenja

Tekst zadatka:

Ispisati tablicu množenja broja koji korisnik unese.

Kod: */

/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite broj: ");
        int broj = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{broj} x {i} = {broj * i}");
    }
} */

/* Objašnjenje:

Petlja se koristi za ispis deset redova rezultata množenja. */

/* Zadatak 8: Faktorijel broja

Tekst zadatka:

Izračunati faktorijel broja n (n!).

Kod: */

/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite broj: ");
        int n = int.Parse(Console.ReadLine());
        int faktorijel = 1;

        for (int i = 1; i <= n; i++)
            faktorijel *= i;

        Console.WriteLine($"Faktorijel broja {n} je {faktorijel}");
    }
} */

/* Objašnjenje:

Petlja množi sve brojeve od 1 do n da bi se dobio faktorijel. */

/* Zadatak 9: Suma parnih brojeva do 100

Tekst zadatka:
Izračunati sumu svih parnih brojeva od 1 do 100.

Kod: */

/* using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 2; i <= 100; i += 2)
            suma += i;

        Console.WriteLine("Suma parnih brojeva do 100 je: " + suma);
    }
} */

/*Objašnjenje: Petlja sabira samo parne brojeve tako što povećava brojač za 2.


/* Zadatak 10: Brojanje samoglasnika

Tekst zadatka:
Unosi se tekst, a program broji koliko ima samoglasnika.

Kod: */

/*  using System;

class Program
{
   static void Main()
   {
       Console.Write("Unesite tekst: ");
       string tekst = Console.ReadLine().ToLower();
       int brojac = 0;

       foreach (char c in tekst)
       {
           if ("aeiou".Contains(c))
               brojac++;
       }

       Console.WriteLine("Broj samoglasnika: " + brojac);
   }
} */

/*Objašnjenje: Korištenjem foreach petlje i metode Contains() provjerava se svako slovo. */

/* Zadatak 11: Pronalaženje najvećeg broja u nizu

Tekst zadatka:

Korisnik unosi koliko brojeva želi unijeti, a zatim unosi te brojeve. Program pronalazi najveći broj u nizu.

Kod: */

/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Koliko brojeva želite unijeti? ");
        int n = int.Parse(Console.ReadLine());
        int[] brojevi = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Unesite broj {i + 1}: ");
            brojevi[i] = int.Parse(Console.ReadLine());
        }

        int max = brojevi[0];
        foreach (int broj in brojevi)
        {
            if (broj > max)
                max = broj;
        }

        Console.WriteLine("Najveći broj u nizu je: " + max);
    }
} */

/* Objašnjenje:

Koristi se niz i foreach petlja za pronalazak najveće vrijednosti. */

/* Zadatak 12: Suma pozitivnih i negativnih brojeva

Tekst zadatka:

Program prima 10 brojeva i računa zbir pozitivnih i zbir negativnih brojeva odvojeno.

Kod: */

/* using System;

class Program
{
   static void Main()
   {
       int sumaPozitivnih = 0, sumaNegativnih = 0;

       for (int i = 1; i <= 10; i++)
       {
           Console.Write($"Unesite broj {i}: ");
           int broj = int.Parse(Console.ReadLine());

           if (broj >= 0)
               sumaPozitivnih += broj;
           else
               sumaNegativnih += broj;
       }

       Console.WriteLine($"Suma pozitivnih: {sumaPozitivnih}");
       Console.WriteLine($"Suma negativnih: {sumaNegativnih}");
   }
} */

/* Objašnjenje:

Program koristi if uslove za razdvajanje pozitivnih i negativnih vrijednosti. */

/* Zadatak 13: Prosti brojevi

Tekst zadatka:

Korisnik unosi broj n, a program ispisuje sve proste brojeve do tog broja.

Kod: */

/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite broj n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Prosti brojevi do " + n + " su:");

        for (int i = 2; i <= n; i++)
        {
            bool prost = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    prost = false;
                    break;
                }
            }

            if (prost)
                Console.Write(i + " ");
        }
    }
} */

/* Objašnjenje:

Koriste se dvije ugniježđene petlje za provjeru djeljivosti svakog broja. */

/* Zadatak 14: Palindrom

Tekst zadatka:

Program provjerava da li je unesena riječ palindrom (čita se isto s obje strane).

Kod: */

/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite riječ: ");
        string rijec = Console.ReadLine().ToLower();

        char[] niz = rijec.ToCharArray();
        Array.Reverse(niz);
        string obrnuto = new string(niz);

        if (rijec == obrnuto)
            Console.WriteLine("Riječ je palindrom.");
        else
            Console.WriteLine("Riječ nije palindrom.");
    }
} */

/* Objašnjenje:

Korištenjem Array.Reverse() obrće se tekst i poredi s originalom. */

/* Zadatak 15: Sabiranje pomoću metode

Tekst zadatka:

Napisati metodu koja prima dva broja i vraća njihov zbir.

Kod: */

/* using System;

class Program
{
    static int Saberi(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.Write("Unesite prvi broj: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Unesite drugi broj: ");
        int y = int.Parse(Console.ReadLine());

        int rezultat = Saberi(x, y);
        Console.WriteLine("Zbir je: " + rezultat);
    }
} */

/* Objašnjenje:

Korištena je metoda koja prima parametre i vraća rezultat tipa int. */

/* Zadatak 16: Klasa Osoba

Tekst zadatka:

Definisati klasu Osoba sa atributima ime i godine te metodom koja ispisuje te podatke.

Kod: */

/* using System;

class Osoba
{
   public string Ime;
   public int Godine;

   public void PrikaziPodatke()
   {
       Console.WriteLine($"Ime: {Ime}, Godine: {Godine}");
   }
}

class Program
{
   static void Main()
   {
       Osoba o = new Osoba();
       Console.Write("Unesite ime: ");
       o.Ime = Console.ReadLine();
       Console.Write("Unesite godine: ");
       o.Godine = int.Parse(Console.ReadLine());

       o.PrikaziPodatke();
   }
} */

/* Objašnjenje:

Primjer osnovnog korištenja klase, atributa i metode u OOP-u. */

/* Zadatak 17: Klasa Pravougaonik

Tekst zadatka:

Napraviti klasu Pravougaonik sa svojstvima širina i visina, te metodama za izračunavanje površine i obima.

Kod: */

/* using System;

class Pravougaonik
{
    public double Sirina;
    public double Visina;

    public double Povrsina()
    {
        return Sirina * Visina;
    }

    public double Obim()
    {
        return 2 * (Sirina + Visina);
    }
}

class Program
{
    static void Main()
    {
        Pravougaonik p = new Pravougaonik();
        Console.Write("Unesite širinu: ");
        p.Sirina = double.Parse(Console.ReadLine());
        Console.Write("Unesite visinu: ");
        p.Visina = double.Parse(Console.ReadLine());

        Console.WriteLine($"Površina: {p.Povrsina()}, Obim: {p.Obim()}");
    }
} */

/* Objašnjenje:

Koriste se metode koje vraćaju rezultat i rade s double vrijednostima. */

/* Zadatak 18: Nasljeđivanje klasa

Tekst zadatka:

Napraviti baznu klasu Zivotinja i izvedenu klasu Pas.
Klasa Pas nasljeđuje klasu Zivotinja i ima dodatnu metodu “Laj”.

Kod: */

/* using System;

class Zivotinja
{
    public string Ime;

    public void KreciSe()
    {
        Console.WriteLine($"{Ime} se kreće.");
    }
}

class Pas : Zivotinja
{
    public void Laj()
    {
        Console.WriteLine($"{Ime} laje: Vau vau!");
    }
}

class Program
{
    static void Main()
    {
        Pas pas = new Pas();
        Console.Write("Unesite ime psa: ");
        pas.Ime = Console.ReadLine();

        pas.KreciSe();
        pas.Laj();
    }
} */

/* Objašnjenje:

Prikazuje osnovni primjer nasljeđivanja i korištenja metoda iz bazne i izvedene klase. */

/* Zadatak 19: Klasa Bankovni račun

Tekst zadatka:

Napraviti klasu BankovniRacun sa atributima broj računa i stanje.
Dodati metode za uplatu i isplatu novca.

Kod: */

/* using System;

class BankovniRacun
{
    public string BrojRacuna;
    public double Stanje;

    public void Uplata(double iznos)
    {
        Stanje += iznos;
    }

    public void Isplata(double iznos)
    {
        if (iznos <= Stanje)
            Stanje -= iznos;
        else
            Console.WriteLine("Nedovoljno sredstava!");
    }

    public void PrikaziStanje()
    {
        Console.WriteLine($"Račun: {BrojRacuna}, Stanje: {Stanje} KM");
    }
}

class Program
{
    static void Main()
    {
        BankovniRacun racun = new BankovniRacun();
        Console.Write("Unesite broj računa: ");
        racun.BrojRacuna = Console.ReadLine();

        racun.Uplata(1000);
        racun.Isplata(250);
        racun.PrikaziStanje();
    }
} */

/* Objašnjenje:

Demonstrira metode koje mijenjaju stanje objekta i provjeravaju uslove. */

/* Upustvo za upotrebu: U slučaju da želite provjeriti tačnost koda dovoljno je da izbrisete znakove za komentarisanje te nakon toga možete pokrenuti kod u terminalu. */

/* Zadatak 20: Napredni sistem studenata

Tekst zadatka:
Napisati program koji omogućava unos više studenata (ime, prezime, broj indeksa i prosjek).
Program treba:

* ispisati sve unijete studente,
* izračunati prosječan prosjek svih studenata,
* pronaći najboljeg studenta (onog s najvećim prosjekom),
* prikazati broj studenata koji imaju prolaznu ocjenu (prosjek >= 2.5).

Kod: */

/* using System;
using System.Collections.Generic;

class Student
{
   public string Ime;
   public string Prezime;
   public string Indeks;
   public double Prosjek;

   // Metoda koja ispisuje podatke o studentu
   public void Prikazi()
   {
       Console.WriteLine($"{Ime} {Prezime} | Indeks: {Indeks} | Prosjek: {Prosjek}");
   }
}

class Program
{
   static void Main()
   {
       Console.Write("Koliko studenata želite unijeti? ");
       int n = int.Parse(Console.ReadLine());

       List<Student> studenti = new List<Student>(); // Lista za čuvanje studenata

       // Unos podataka o studentima
       for (int i = 1; i <= n; i++)
       {
           Console.WriteLine($"\nUnos podataka za studenta {i}:");
           Student s = new Student();

           Console.Write("Ime: ");
           s.Ime = Console.ReadLine();

           Console.Write("Prezime: ");
           s.Prezime = Console.ReadLine();

           Console.Write("Broj indeksa: ");
           s.Indeks = Console.ReadLine();

           Console.Write("Prosjek: ");
           s.Prosjek = double.Parse(Console.ReadLine());

           studenti.Add(s);
       }

       Console.WriteLine("\n===== Podaci o studentima =====");
       foreach (Student s in studenti)
           s.Prikazi();

       // Izračunavanje prosječnog prosjeka
       double ukupno = 0;
       foreach (Student s in studenti)
           ukupno += s.Prosjek;

       double prosjekSvih = ukupno / studenti.Count;
       Console.WriteLine($"\nProsječan prosjek svih studenata: {prosjekSvih:F2}");

       // Pronalaženje najboljeg studenta
       Student najbolji = studenti[0];
       foreach (Student s in studenti)
       {
           if (s.Prosjek > najbolji.Prosjek)
               najbolji = s;
       }

       Console.WriteLine(
           $"\nNajbolji student: {najbolji.Ime} {najbolji.Prezime} (Prosjek: {najbolji.Prosjek})"
       );

       // Brojanje studenata sa prolaznom ocjenom
       int brojProlaznih = 0;
       foreach (Student s in studenti)
       {
           if (s.Prosjek >= 2.5)
               brojProlaznih++;
       }

       Console.WriteLine($"Broj studenata sa prolaznom ocjenom: {brojProlaznih}");
   }
} */

/* Objašnjenje:
Ovaj program koristi klasu Student i listu za pohranu više studenata.
Prikazuje sve unose, računa prosjek, pronalazi najboljeg i broji prolazne. */
