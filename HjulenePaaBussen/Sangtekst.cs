using System;
using System.Text;

public class Sangtekst
{
	public Sangtekst()
	{
    }

    private List<string> versPrimaer = new List<string>
	{
        "Hjulene på bussen drejer ",
        "Dørene på bussen siger ",
        "Pengene i bussen siger ",
        "Fruerne i bussen siger ",
        "Børnene i bussen siger ",
        "Hornet i bussen siger "

    };

    private List<string> versPrimaerTekst = new List<string>();

    private List<string> versGentagelser = new List<string>
	{
		"rundt, rundt, rundt",
        "åben og luk, åben og luk, åben og luk",
        "klir, klir, klir",
        "snak, snak, snak",
        "vræh, vræh, vræh",
        "båt, båt, båt"

    };

    private List<string> versGentagelserTekst = new List<string> ();
    private string versSlut = "Gennem hele byen";

    public void UdskrivSangTekst ()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < versPrimaer.Count; i++)
        {
            versPrimaerTekst.Add(this.versPrimaer[i] + this.versGentagelser[i]);
        }

        for (int i = 0; i < versGentagelser.Count; i++)
        {
            string firstLetterUpperCase = versGentagelser[i].Substring(0, 1).ToUpper();
            string restLettersLowerCase = versGentagelser[i].Substring(1).ToLower();
            this.versGentagelserTekst.Add(firstLetterUpperCase + restLettersLowerCase);
        }


        for (int i = 0; i < versPrimaer.Count; i++)
        {
            byte AntalGentagelser = 2;
            Console.WriteLine(this.versPrimaerTekst[i]);
            for (int j = 0; j < AntalGentagelser; j++)
            {
                Console.WriteLine(this.versGentagelserTekst[i]);
            }
            Console.WriteLine(this.versPrimaerTekst[i]);
            Console.WriteLine(this.versSlut);
            Console.WriteLine();
        }
    }

}
