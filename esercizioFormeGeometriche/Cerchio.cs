using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Cerchio : FormaGeometrica
{
    public double raggio { get; set; }


    public Cerchio(double raggio)
    {
        this.raggio = raggio;
    }

    public override double CalcolaArea()
    {
        return Math.PI * Math.Pow(raggio, 2);
    }

    public override double CalcolaPerimetro()
    {
        return 2 * Math.PI * raggio;
    }
}