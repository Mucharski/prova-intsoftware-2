namespace ProvaSoftware.Data.Models;

public class FolhaDePagamento
{
    public int Id { get; set; }
    public string Mes { get; set; }
    public int Ano { get; set; }
    public int Horas { get; set; }
    public decimal Bruto { get; set; }
    public decimal Inss { get; set; }
    public decimal Irrf { get; set; }
    public decimal Fgts { get; set; }
    public decimal Liquido { get; set; }
}