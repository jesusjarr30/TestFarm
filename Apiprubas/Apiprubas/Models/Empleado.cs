using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Apiprubas.Models;

public partial class Empleado
{
    public int Id { get; set; }
    public string? Nombre { get; set; }

    public int? Suledo { get; set; }

    public int? IdDireccion { get; set; }

    [JsonIgnore]
    public virtual Direccion? IdDireccionNavigation { get; set; }
}
