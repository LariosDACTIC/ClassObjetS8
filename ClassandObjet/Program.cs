namespace ClassandObjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, mundo!");

            //*Person*//

            // Crear un objeto de tipo Persona
            Person persona1 = new Person();
            persona1.Nombre = "Cristopher";
            persona1.Edad = 26;

            Person persona2 = new Person();
            persona2.Nombre = "Michael";
            persona2.Edad = 25;


            //// Llamar al método Saludar
            persona1.Saludar();
            persona2.Saludar();


            ////*PersonPropietis*//


            //Crear un Objeto de la clase PersonPropietis

            Personproperties p1 = new Personproperties();

            // Establecer el valor de la propiedad Nombre
            p1.Nombre = "Cristopher";//seteamos la informacion

            // Obtener el valor de la propiedad Nombre

            Console.WriteLine(p1.Nombre); // Obtenemos de la propiedad Get


            EdadValidate validaredad = new EdadValidate();

            //                                        //Argumento //Verdadero          //Falso
            Console.WriteLine((validaredad.validateAge(18)) ? "Es mayor de edad" : "Es Menor de edad");


            //*PersonConstrctor*//

            // Usando el constructor por defecto
            PersonConstructor persona3 = new PersonConstructor();
            Console.Write("Objeto Persona 3 ");
            Console.WriteLine($"Nombre: {persona3.Nombre}, Edad: {persona3.Edad}, estado: {persona3.Estado}");

            // Usando el constructor con parámetros
            PersonConstructor persona4 = new PersonConstructor("Larios", 26);
            Console.Write("Objeto persona 4 ");
            Console.WriteLine($"Nombre: {persona4.Nombre}, Edad: {persona4.Edad},estado: {persona4.Estado}");

        }
    }
}
