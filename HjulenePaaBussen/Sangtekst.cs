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
	
	private List<string> versGentagelser = new List<string>
	{
		"rundt, rundt, rundt",
        "åben og luk, åben og luk, åben og luk",
        "klir, klir, klir",
        "snak, snak, snak",
        "vræh, vræh, vræh",
        "båt, båt, båt"

    };

    private string versSlut = "Gennem hele byen";

    private void UdskrivSangTekst ()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.versPrimaer[0] + this.versGentagelser[0]);
        string versPrimaerTekst = sb.ToString();
        Console.WriteLine(versPrimaerTekst);

        string firstLetterUpperCase = versGentagelser[0].Substring(0, 1).ToUpper();
        string restLettersLowerCase = versGentagelser[0].Substring(1).ToLower();

        sb.Clear();
        sb.Append(firstLetterUpperCase + restLettersLowerCase);
        string versGentagelserTekst = sb.ToString();
        Console.WriteLine(versGentagelserTekst);
        Console.WriteLine(versSlut);
    }

}
