using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Quadrato : FormaGeometrica
{
    public double lato { get; set; }

    public Quadrato(double lato)
    {
        this.lato = lato;
    }

    public override double CalcolaArea()
    {
        return lato * lato;
    }

    public override double CalcolaPerimetro()
    {
        return lato * 4;
    }
}