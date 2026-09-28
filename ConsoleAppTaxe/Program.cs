namespace ConsoleAppTaxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal taxeCapital, taxeNains, taxeTemple, taxeContreBandiers, TaxeTotale = 0m;

            Console.WriteLine("Entrez le prix de base de l'arme");
            decimal prixBase = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Entrez la provenance de ma forge");
            string provenance = Console.ReadLine();

            switch (provenance.ToLower())
            {
                case "capital":
                    taxeCapital = prixBase * 0.20m;
                    Console.WriteLine($"La taxe pour la provenance 'capital' est de : {taxeCapital}");
                    TaxeTotale = taxeCapital;
                    break;
                case "nains":
                    taxeNains = prixBase * 0.10m;
                    Console.WriteLine($"La taxe pour la provenance 'nains' est de : {taxeNains}");
                    TaxeTotale = taxeNains;
                    break;
                case "temple":
                    taxeTemple = prixBase * 0.021m;
                    Console.WriteLine($"La taxe pour la provenance 'temple' est de : {taxeTemple}");
                    TaxeTotale = taxeTemple;
                    break;
                case "contrebandiers":
                    taxeContreBandiers = prixBase * 0.055m;
                    Console.WriteLine($"La taxe pour la provenance 'contrebandiers' est de : {taxeContreBandiers}");
                    TaxeTotale = taxeContreBandiers;
                    break;

                default:
                    Console.WriteLine("Provenance non reconnue. Aucune taxe calculée.");
                    TaxeTotale = 0m; 
                    break;
            }
            Console.WriteLine($"Prix Final avec taxe : {prixBase + TaxeTotale}");
        }
    }   
}
