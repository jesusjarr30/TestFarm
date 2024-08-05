using System;
using System.Collections.Generic;

namespace IntroNet.Models;

public partial class Modelo
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? IdMarca { get; set; }

    public virtual Marca? IdMarcaNavigation { get; set; }
}
