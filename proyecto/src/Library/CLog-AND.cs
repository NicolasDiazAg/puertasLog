namespace Program;

public class CLogAND
{
    public string nombre;
    public Dictionary<string, object> entradas;
    public int salida;

    public CLogAND(string nombre)
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
        int prod = 1;
        foreach (var entrada in entradas.Values)
        {
            if (entrada is int valor && (valor == 0 || valor == 1))
            {
                prod *= valor;
            }
            else if (entrada is CLogAND || entrada is CLogOR || entrada is CLogNOT)
            {
                prod *= ((dynamic)entrada).Calcular();
            }
        }
        return prod;
    }
}