public class Cachorro : Animal, ISom, Ipular
{
    public Cachorro()
    {
    }

    public string SomEmitido()
    {
        return "Cachorro Latindo";
    }

    public string Pular()
    {
        return "Cachorro pulando";
    }

    public override string ToString()
    {
        return $"Cachorro{{tipo='{Tipo}', nome='{Nome}'}}";
    }
}
