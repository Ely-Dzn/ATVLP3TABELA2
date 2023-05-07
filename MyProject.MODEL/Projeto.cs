using System;
using System.Collections.Generic;

namespace Myprojec.MODEL;

public partial class Projeto
{

    public Projeto() { }
    public int Id { get; set; }

    public string? NomedoProjeto { get; set; }

    public string? NomedoGerentedoProjeto { get; set; }

    public DateTime? DatainiciodoProjeto { get; set; }

    public DateTime? DatafimdoProjeto { get; set; }

    public string? ReseumodoProjeto { get; set; }

    public int IdStatus { get; set; }

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public Projeto(string NomedoProjeto, string NomedoGerentedoProjeto, DateTime DatainiciodoProjeto, DateTime DatafimdoProjeto, string ReseumodoProjeto, int IdStatus)
    {
        
        this.NomedoProjeto = NomedoProjeto;
        this.NomedoGerentedoProjeto = NomedoGerentedoProjeto;
        this.DatainiciodoProjeto = DatainiciodoProjeto;
        this.DatafimdoProjeto = DatafimdoProjeto;
        this.ReseumodoProjeto = ReseumodoProjeto;
        this.IdStatus = IdStatus;
        
    }
}
