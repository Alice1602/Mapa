namespace Mapas;

public interface IProvedorMapa
{
    public string NomeProvedor { get; }
    
    string Mapa (string coordenadas);
    string Rota (string origem, string destino);
}