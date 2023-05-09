class Escuelas
{
    public string Matricula { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string CURP { get; set; }

    public Escuelas(string matricula, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string curp)
    {
        Matricula = matricula;
        Nombre = nombre;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
        FechaNacimiento = fechaNacimiento;
        CURP = curp;
    }
}