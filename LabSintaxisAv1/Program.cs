using Provincias;




List<Provincia> provincias = new List<Provincia>
        {
            new Provincia { nombre = "Buenos Aires" },
            new Provincia { nombre = "Catamarca" },
            new Provincia { nombre = "Chaco" },
            new Provincia { nombre = "Chubut" },
            new Provincia { nombre = "Córdoba" },
            new Provincia { nombre = "Corrientes" },
            new Provincia { nombre = "Entre Ríos" },
            new Provincia { nombre = "Formosa" },
            new Provincia { nombre = "Jujuy" },
            new Provincia { nombre = "La Pampa" },
            new Provincia { nombre = "La Rioja" },
            new Provincia { nombre = "Mendoza" },
            new Provincia { nombre = "Misiones" },
            new Provincia { nombre = "Neuquén" },
            new Provincia { nombre = "Río Negro" },
            new Provincia { nombre = "Salta" },
            new Provincia { nombre = "San Juan" },
            new Provincia { nombre = "San Luis" },
            new Provincia { nombre = "Santa Cruz" },
            new Provincia { nombre = "Santa Fe" },
            new Provincia { nombre = "Santiago del Estero" },
            new Provincia { nombre = "Tierra del Fuego" },
            new Provincia { nombre = "Tucumán" }
        };



var provinciasSelect=

from p in provincias

where p.nombre.StartsWith("S")||p.nombre.StartsWith("T")
select p;

foreach (var p in provinciasSelect)
{
    Console.WriteLine(p.nombre);
}
