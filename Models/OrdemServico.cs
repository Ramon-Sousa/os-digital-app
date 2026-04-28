namespace OsDigitalMVP.Models;

public class OrdemServico
{
    public int Id { get; set; }
    public string ClienteNome { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;
    public string CEP { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
}