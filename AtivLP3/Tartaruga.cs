public class Tartaruga : Animal, ISom
{
    public Tartaruga()
    {
    }

    public string SomEmitido()
    {
        return "Tartaruga emitindo som";
    }

    public override string ToString()
    {
        return $"Tartaruga{{tipo='{Tipo}', nome='{Nome}'}}";
    }
}
