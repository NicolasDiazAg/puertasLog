namespace Program;

class Program
{
    static void Main()
    {
        CLogAND and1 = new CLogAND("AND1");
        and1.AgregarEntrada("A", 0);
        and1.AgregarEntrada("B", 0);

        CLogOR or2 = new CLogOR("OR2");
        or2.AgregarEntrada("C", 0);
        or2.AgregarEntrada(and1.GetNombre(), and1);

        CLogNOT not3 = new CLogNOT("NOT3");
        not3.AgregarEntrada(or2.GetNombre(), or2);

        Console.WriteLine($"Resultado final: {and1.Calcular()}{or2.Calcular()}{not3.Calcular()}");

    }
    
}
