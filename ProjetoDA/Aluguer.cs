
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ProjetoDA
{

using System;
    using System.Collections.Generic;
    
public partial class Aluguer
{

    public int IdAluguer { get; set; }

    public string DataInicio { get; set; }

    public string DataFim { get; set; }

    public string Valor { get; set; }

    public string Kms { get; set; }

    public string ClienteIdCliente { get; set; }

    public int ClienteIdCliente1 { get; set; }



    public virtual Cliente Cliente { get; set; }

    public virtual CarroAluguer CarroAluguer { get; set; }

}

}
