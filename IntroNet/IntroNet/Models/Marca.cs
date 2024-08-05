using System;
using System.Collections.Generic;

namespace IntroNet.Models;

public partial class Marca
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();
}
