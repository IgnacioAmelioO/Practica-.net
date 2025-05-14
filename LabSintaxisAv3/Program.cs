using Ciudades;

List<Ciudad> ciudades = new List<Ciudad>
{ new Ciudad { nombre = "CABA", codPostal = "C1000" },
    new Ciudad { nombre = "Jujuy", codPostal = "J9000" },
    new Ciudad { nombre = "La Plata", codPostal = "B1900" },
    new Ciudad { nombre = "Mar del Plata", codPostal = "B7600" },
    new Ciudad { nombre = "Bahía Blanca", codPostal = "B8000" },
    new Ciudad { nombre = "Rosario", codPostal = "S2000" },
    new Ciudad { nombre = "Córdoba", codPostal = "X5000" },
    new Ciudad { nombre = "San Juan", codPostal = "SJ9090" },
    new Ciudad { nombre = "San Luis", codPostal = "SN6045" },
    new Ciudad { nombre = "Mendoza", codPostal = "M5500" }
};

Console.WriteLine("Ingrese el nombre de la ciudad a buscar: "); 
string busqueda = Console.ReadLine();

var ciudadesSelect =
    from c in ciudades
    where c.nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase)
    select c;

foreach (var c in ciudadesSelect)
{
    Console.WriteLine(c.codPostal);
}