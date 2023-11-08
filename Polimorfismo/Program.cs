
using Polimorfismo;
Inmueble inmueble = new Casa("Casa", 70000);
Casa casa1 = new Casa("Casa de campo", 60000);
Departamento depto = new Departamento("Departamento duplex", 100000);
Terreno terreno = new Terreno("Terreno", 30000);

Casa casa2 = new Casa();
casa2.tipoInmueble = "Hotel";
casa2.precio = 150000;

inmueble.vender();
casa1.vender();
casa1.vender(1000);
depto.vender();
terreno.vender();
casa2.vender();

List<Casa> lista = new List<Casa>();
lista.Add(casa1);
lista.Add(casa2);
lista.Add(new Casa("Caja de fosforo", 10000));
lista.Add(new Casa("Casa Sencilla", 80000));

Console.WriteLine("******************Lista de Casas******************");
foreach (Casa casa in lista)
{
    casa.vender();
}