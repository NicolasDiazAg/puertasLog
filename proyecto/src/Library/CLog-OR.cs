namespace Program;

public class CLogOR
{
    private string nombre;
    private Dictionary<string, object> entradas;
    private int salida;

    public CLogOR(string nombre)
    {
        this.nombre = nombre;
        this.entradas = new Dictionary<string, object>();
        this.salida = 0;
    }

    public string GetNombre()
    {
        return nombre;
    }
    public override string ToString()
    {
        return nombre;
    }
    public void AgregarEntrada(string conector, object valor)
    {
        entradas[conector] = valor;
    }
    
    public int Calcular()
    {
        int suma = 0;
        foreach (var entrada in entradas.Values)
        {
            if (entrada is int valor && (valor == 0 || valor == 1))
            {
                suma += valor;
            }
            else if (entrada is CLogAND || entrada is CLogOR || entrada is CLogNOT)
            {
                suma += ((dynamic)entrada).Calcular();
            }
        }
        return suma;
    }
}