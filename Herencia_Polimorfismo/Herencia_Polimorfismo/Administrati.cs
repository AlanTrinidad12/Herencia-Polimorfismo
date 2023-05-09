class Administrativo : Escuelas
{
    public Administrativo(string matricula, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string curp) : base(matricula, nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, curp)
    {
        Matricula = matricula;
        Nombre = nombre;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
        FechaNacimiento = fechaNacimiento;
        CURP = curp;
    }
    public void EnseñarDato()
    {
        Console.WriteLine("Nombre es: " + Nombre);
        Console.WriteLine("Matricula es: " + Matricula);
        Console.WriteLine("Apellido paterno es: " + ApellidoPaterno);
        Console.WriteLine("Apellido materno es: " + ApellidoMaterno);
        Console.WriteLine("La CURP es: " + CURP);
        Console.WriteLine("La fecha de nacimiento es: " + FechaNacimiento);
    }
}