using _26_3;

List<Participante> Participantes = new();
int Nro = 9999;
do
{
    Console.WriteLine("Ingrese Nro del participante");
    Nro = int.Parse(Console.ReadLine());
    if (Nro != 0)
    {
        Participante P = new(Nro);
        Console.WriteLine("Ingrese Nombre");
        P.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese Apellido");
        P.Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese Tiempo");
        P.Tiempo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Altura");
        P.Altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Categoria");
        P.Categoria = Console.ReadLine();

        Participantes.Add(P);
    }
} while (Nro != 0);

Participante? mejorParticipante = MejorTiempo();
if (mejorParticipante != null)
{
    Console.WriteLine($"El participante {mejorParticipante.Nombre} tiene el mejor tiempo: {mejorParticipante.Tiempo}");
}
    

List<string> categorias = ObtenerCategorias();

if (categorias.Count != 0)
{
    foreach (string categoria in categorias)
    {
        Participante? mejorParticipanteCategoria = MejorTiempoPorCategoria(categoria);
        if (mejorParticipanteCategoria != null)
        {
            Console.WriteLine($"El participante {mejorParticipanteCategoria.Nombre} tiene el mejor tiempo: {mejorParticipanteCategoria.Tiempo} en la categoría: {categoria}");
        }            
    }
}

Participante? MejorTiempo()
{
    if (Participantes.Count != 0)
    {
        Participante? mejorParticipante = null;
        double mejorTiempo = double.MaxValue;
        foreach (Participante participante in Participantes)
        {
            if (participante.Tiempo < mejorTiempo)
            {
                mejorParticipante = participante;
                mejorTiempo = participante.Tiempo;
            }
        }
        return mejorParticipante;
    }
    return null;
}

Participante? MejorTiempoPorCategoria(string categoria)
{
    if (Participantes.Count != 0)
    {
        Participante? mejorParticipante = null;
        double mejorTiempo = double.MaxValue;
        foreach (Participante participante in Participantes)
        {
            if (participante.Categoria == categoria && participante.Tiempo < mejorTiempo)
            {
                mejorParticipante = participante;
                mejorTiempo = participante.Tiempo;
            }
        }
        return mejorParticipante;
    }
    return null;
}

List<string> ObtenerCategorias()
{
    List<string> categorias = new List<string>();

    if (Participantes.Count != 0)
    {
        categorias.Add(Participantes[0].Categoria);

        foreach (Participante participante in Participantes)
        {
            bool existeCategoria = false;
            foreach (string categoria in categorias)
            {
                if (participante.Categoria == categoria)
                {
                    existeCategoria = true;
                    break;
                }

                if (existeCategoria == false)
                {
                    categorias.Add(participante.Categoria);
                    break;
                }
            }
        }
    }

    return categorias;
}

Console.ReadKey();