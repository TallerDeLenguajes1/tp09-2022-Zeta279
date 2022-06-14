using System.Text.Json;

namespace TrabajoPractico9{
    class Program{
        static void Main(string[] args){
            string path;
            int cantidad;
            List<Producto> listaProductos = new List<Producto>();

            Console.Write("Escribe una ruta: ");
            path = Console.ReadLine();

            if(!File.Exists(path + @"/index.json")){
                File.Create(path + @"/index.json").Close();
            }

            path += @"/index.json";

            Console.Write("Ingresar la cantidad de productos a generar: ");
            cantidad = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < cantidad; i++){
                listaProductos.Add(new Producto());
            }

            string archivoJson = JsonSerializer.Serialize(listaProductos);
            File.WriteAllText(path, archivoJson);

            listaProductos = JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText(path));

            foreach(Producto prod in listaProductos){
                Console.WriteLine(prod + "\n");
            }
        }
    }
}