namespace Program;

public class CLogNOT
{
    private string nombre;
    private Tuple<string, object> entrada = new Tuple<string, object>(null, null);
    public object salida;

    public CLogNOT(string nombre)
    {
        this.nombre = nombre;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public void AgregarEntrada(string conector, object valor)
    {
        entrada = new Tuple<string, object>(conector, valor);
    }

    public override string ToString()
    {
        return nombre;
    }

    public int Calcular()
    {
        if (entrada.Item2 is int valor)
        {
            if (valor == 1)
            {
                return 0;
            }
            else if (valor == 0)
            {
                return 1;
            }
        }
        else if (entrada.Item2 is CLogAND || entrada.Item2 is CLogOR || entrada.Item2 is CLogNOT)
        {
            int salida = ((dynamic)entrada.Item2).Calcular();
            if (salida == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        return 0;
    }
}
