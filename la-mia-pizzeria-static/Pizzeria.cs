namespace la_mia_pizzeria_static
{
    public class Pizzeria
    {
        public string Name { get; set; }
        public List<Pizza> pizzas { get; set; } = new List<Pizza>();

        public Pizzeria(string name) // Mi rendo conto che in questo modo ogni pizzeria creata avrà questo elenco di pizze predefinito ma al momento è un comportamento voluto 
        {
            Name = name;

            Pizza norma = new Pizza("NORMA", "Passata di pomodoro San Marzano Dop, provola affumicata d’Agerola, melanzane al forno, pomodorini semi dry, ricotta salata, basilico fresco, olio extra vergine d’oliva biologico.", "~/img/Marghe-Norma.webp", 10.50);
            pizzas.Add(norma);

            Pizza napoletana = new Pizza("NAPOLI", "Passata di pomodoro San Marzano Dop, fior di latte d’Agerola, alici di Cetara, olive caiazzane, capperi di Salina, origano, basilico fresco, olio extravergine d’oliva biologico.", "~/img/marghe-napoli.webp", 9.50);
            pizzas.Add(napoletana);

            Pizza vegana = new Pizza("VEGANA", "Creazione della settimana con prodotti stagionali", "~/img/Marghe-Vegana.webp", 7.50);
            pizzas.Add(vegana);

            Pizza diavola = new Pizza("DIAVOLA GIALLA", "Passata di pomodorini del Piannolo del Vesuvio gialli, fior di latte d’Agerola, salamino piccante di Secondigliano, fili di peperoncino, nduja, basilico fresco, olio extravergine d’oliva biologico", "~/img/Marghe-Diavola.webp", 12.50);
            pizzas.Add(diavola);

            Pizza melanzanePorchetta = new Pizza("MELANZANE E PORCHETTA D’ARICCIA", "Crema di melanzane cotte nel forno a legna, fior di latte, provola affumicata, porchetta d’Ariccia, taralli pugliesi, crema di pomodorini del Piennolo del Vesuvio gialli, rosmarino, olio extravergine d’oliva biologico", "~/img/Marghe-Melanzane-e-porchetta.webp", 11.50);
            pizzas.Add(melanzanePorchetta);
        }
    }
}
