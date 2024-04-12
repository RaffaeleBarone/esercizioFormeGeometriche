class Program
{
    static void Main(string[] args)
    {
        //FormaGeometrica quadrato = new Quadrato();
        //quadrato.CalcolaArea();
        //quadrato.CalcolaPerimetro();

        //FormaGeometrica cerchio = new Cerchio();
        //cerchio.CalcolaArea();
        //cerchio.CalcolaPerimetro();

        List<IFormaGeometrica> quadrati = new List<IFormaGeometrica>();
        {
            quadrati.Add(new Quadrato(5));
           
        }

        foreach (IFormaGeometrica quadrato in quadrati)
        {
            Console.WriteLine($"Area : {quadrato.CalcolaArea()}, Perimetro: {quadrato.CalcolaPerimetro()}");
        }

        List<IFormaGeometrica> cerchi = new List<IFormaGeometrica>();
        {
            cerchi.Add(new Cerchio(5.66));
        }

        foreach(IFormaGeometrica cerchio in cerchi)
        {
            Console.WriteLine($"Area : {cerchio.CalcolaArea()}, Perimetro: {cerchio.CalcolaPerimetro()}");
        }
    }
}