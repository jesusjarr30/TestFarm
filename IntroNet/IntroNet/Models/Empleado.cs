using System;
using System.Collections.Generic;

namespace IntroNet.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Suledo { get; set; }

    public int? IdDireccion { get; set; }

    public virtual Direccion? IdDireccionNavigation { get; set; }
}
