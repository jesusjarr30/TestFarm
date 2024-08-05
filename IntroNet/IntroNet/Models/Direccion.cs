using System;
using System.Collections.Generic;

namespace IntroNet.Models;

public partial class Direccion
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
