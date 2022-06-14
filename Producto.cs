namespace TrabajoPractico9{
    class Producto{
        private string nombre;
        private DateTime fechaVencimiento;
        private float precio;
        private string tam;

        public Producto(){
            string[] listaNombres = {"Yogurt", "Fideos", "Manteca", "Atun", "Mermelada", "Leche", "Gaseosa", "Galleta", "Pan", "Embutido"};
            string[] listaTam = {"Pequeño", "Mediano", "Grande"};
            Random rnd = new Random();

            this.nombre = listaNombres[rnd.Next(0, 10)];
            this.fechaVencimiento = new DateTime();
            this.fechaVencimiento = fechaVencimiento.AddDays(rnd.Next(0, 31));
            this.fechaVencimiento = fechaVencimiento.AddMonths(rnd.Next(0, 13));
            this.fechaVencimiento = fechaVencimiento.AddYears(rnd.Next(2022, 2025));
            this.precio = rnd.Next(1000, 5000);
            this.tam = listaTam[rnd.Next(0, 3)];
        }

        public override string ToString()
        {
            string cadena = "";

            cadena += $"Nombre: {this.nombre}\n";
            cadena += $"Fecha de vencimiento: {this.fechaVencimiento.ToString("dd/MM/yyyy")}\n";
            cadena += $"Precio: {this.precio}\n";
            cadena += $"Tamaño: {this.tam}";

            return cadena;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Tam { get => tam; set => tam = value; }
    }
}