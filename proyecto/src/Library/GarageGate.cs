namespace Program;

public class GarageGate
{
    public CLogAND and3Fin;
    
    public GarageGate (int A, int B, int C)
    {
        var and1 = new CLogAND("AND1");
        and1.AgregarEntrada("A", A);
        and1.AgregarEntrada("B", B);

        var not1 = new CLogNOT("NOT1");
        not1.AgregarEntrada("A", A);

        var not2 = new CLogNOT("NOT2");
        not2.AgregarEntrada("B", B);

        var and2 = new CLogAND("AND2");
        and2.AgregarEntrada("A", not1);
        and2.AgregarEntrada("B", not2);

        var or1 = new CLogOR("OR1");
        or1.AgregarEntrada("A", and1);
        or1.AgregarEntrada("B", and2);

        and3Fin = new CLogAND("AND3");
        and3Fin.AgregarEntrada("A", or1);
        and3Fin.AgregarEntrada("B", C);
        
    }

    public int AbrirGarage()
    {
       return and3Fin.Calcular();
    }
}
