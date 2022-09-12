using System;
using System.Text;

public class Sangtekst
{
	public Sangtekst()
	{
        this.UdskrivSangTekst();

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

    private void UdskrivSangTekst ()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < versPrimaer.Count; i++)
        {
            //sb.Append(this.versPrimaer[i] + this.versGentagelser[i]);
            versPrimaerTekst.Add(this.versPrimaer[i] + this.versGentagelser[i]);
            //sb.Clear();
        }

        for (int i = 0; i < versGentagelser.Count; i++)
        {
            string firstLetterUpperCase = versGentagelser[i].Substring(0, 1).ToUpper();
            string restLettersLowerCase = versGentagelser[i].Substring(1).ToLower();
            this.versGentagelserTekst.Add(firstLetterUpperCase + restLettersLowerCase);
            //sb.Clear();
        }



        //sb.Clear();
        //sb.Append(firstLetterUpperCase + restLettersLowerCase);
        //string versGentagelserTekst = sb.ToString();
        //Console.WriteLine(versGentagelserTekst);

        for (int i = 0; i < versPrimaer.Count; i++)
        {
            Console.WriteLine(this.versPrimaerTekst[i]);
            Console.WriteLine(this.versGentagelserTekst[i]);
            Console.WriteLine(this.versGentagelserTekst[i]);
            Console.WriteLine(this.versPrimaerTekst[i]);
            Console.WriteLine(this.versSlut);
        }
    }

}
