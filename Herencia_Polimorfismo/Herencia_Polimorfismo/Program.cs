using System;
using System.Collections.Generic;

namespace Escuela
{
    class Escuelas
    {

        static void Main(string[] args)
        {
            List<Maestro> maestros = new List<Maestro>();
            List<Alumno> alumnos = new List<Alumno>();
            List<Administrativo> administrativos = new List<Administrativo>();

            // Creamos lista de maestros
            maestros.Add(new Maestro("1234561", "Juan", "Pérez", "González", new DateTime(1970, 1, 1), "GPEJA000101ABC"));
            maestros.Add(new Maestro("1234562", "María", "López", "Hernández", new DateTime(1980, 2, 2), "LMRA800202DEF"));
            maestros.Add(new Maestro("1234563", "Pedro", "García", "Martínez", new DateTime(1965, 3, 3), "PGRA650303GHI"));
            maestros.Add(new Maestro("1234564", "Ana", "Ramírez", "Sánchez", new DateTime(1975, 4, 4), "AERA750404JKL"));
            maestros.Add(new Maestro("1234565", "Jorge", "Guzmán", "Pérez", new DateTime(1985, 5, 5), "JORA850505MNO"));
            maestros.Add(new Maestro("1234566", "Laura", "Torres", "Gómez", new DateTime(1990, 6, 6), "TLRA900606PQR"));
            maestros.Add(new Maestro("1234567", "Francisco", "Castro", "Vargas", new DateTime(1960, 7, 7), "FCRA600707STU"));
            maestros.Add(new Maestro("1234568", "Margarita", "Martínez", "Romero", new DateTime(1971, 8, 8), "RMRA710808VWX"));
            maestros.Add(new Maestro("1234569", "Ricardo", "Hernández", "Álvarez", new DateTime(1983, 9, 9), "CERA830909YZA"));
            maestros.Add(new Maestro("1234570", "Sofía", "Sánchez", "Flores", new DateTime(1978, 10, 10), "FSSO781010BCD"));
            maestros.Add(new Maestro("1234571", "Luis", "González", "Pérez", new DateTime(1969, 11, 11), "GOPL691111EFG"));
            maestros.Add(new Maestro("1234572", "Alejandra", "Díaz", "Hernández", new DateTime(1972, 12, 12), "CERA721212HIJ"));
            maestros.Add(new Maestro("1234573", "Javier", "Fernández", "López", new DateTime(1982, 1, 13), "JFRA820113KLM"));
            maestros.Add(new Maestro("1234574", "Gabriela", "Mendoza", "García", new DateTime(1976, 2, 14), "CERA760214NOP"));
            maestros.Add(new Maestro("1234575", "David", "Álvarez", "Jiménez", new DateTime(1984, 3, 15), "DAJI840315QRS"));
            maestros.Add(new Maestro("1234576", "Karen", "Pérez", "Sánchez", new DateTime(1991, 4, 16), "PESA910416TUV"));
            maestros.Add(new Maestro("1234577", "Miguel", "García", "Hernández", new DateTime(1963, 5, 17), "HIRA630517WXY"));
            maestros.Add(new Maestro("1234578", "Verónica", "Romero", "Flores", new DateTime(1974, 6, 18), "ROFA740618ABC"));
            maestros.Add(new Maestro("1234579", "Carlos", "Vargas", "González", new DateTime(1986, 7, 19), "CAVG860719DEF"));
            maestros.Add(new Maestro("1234580", "Isabel", "López", "Sánchez", new DateTime(1979, 8, 20), "CLSI790820GHI"));
            // Creamos lista de alumnos
            alumnos.Add(new Alumno("12345611", "Alan", "Trinidad", "Arellano", new DateTime(2003, 12, 19), "TIAA031219HCSRRLA1"));
            alumnos.Add(new Alumno("12345612", "María", "López", "Hernández", new DateTime(2001, 2, 2), "LOHM010202JNG"));
            alumnos.Add(new Alumno("12345613", "Amaury", "Rodriguez", "Arellano", new DateTime(2002, 9, 9), "ROAA220909HCSDRMOO"));
            alumnos.Add(new Alumno("12345614", "Karla", "Rios", "villanueva", new DateTime(2003, 4, 4), "RASA030404KLM"));
            alumnos.Add(new Alumno("12345615", "Samuel", "Guzmán", "Pérez", new DateTime(2004, 5, 5), "GUZJ040505NPO"));
            alumnos.Add(new Alumno("12345616", "Lucia", "Torres", "Gómez", new DateTime(2005, 6, 6), "TOGL050606QRT"));
            alumnos.Add(new Alumno("12345617", "Francisco", "Castro", "Vargas", new DateTime(2006, 7, 7), "CASV060707USW"));
            alumnos.Add(new Alumno("12345618", "Esparanza", "Martínez", "Romero", new DateTime(2007, 8, 8), "MARJ070808VAX"));
            alumnos.Add(new Alumno("12345619", "Ricardo", "Hernández", "Álvarez", new DateTime(2008, 9, 9), "HERA080909YBZ"));
            alumnos.Add(new Alumno("12345620", "Andrik", "Sánchez", "Flores", new DateTime(2009, 10, 10), "SAFL091010CKA"));
            alumnos.Add(new Alumno("12345621", "Raul", "González", "Pérez", new DateTime(2010, 11, 11), "GONL101111DEM"));
            alumnos.Add(new Alumno("12345622", "Fernanda", "Rodríguez", "Jiménez", new DateTime(2011, 12, 12), "RODJ111212FEN"));
            alumnos.Add(new Alumno("12345623", "Belen", "García", "Hernández", new DateTime(2012, 1, 13), "GARH120113GHI"));
            alumnos.Add(new Alumno("12345624", "Luis", "Martínez", "Sánchez", new DateTime(2013, 2, 14), "MARS130214JKL"));
            alumnos.Add(new Alumno("12345625", "Emilio", "López", "González", new DateTime(2014, 3, 15), "LOPG140315MNO"));
            alumnos.Add(new Alumno("12345626", "Valentin", "Hernández", "Pérez", new DateTime(2015, 4, 16), "HERP150416PQR"));
            alumnos.Add(new Alumno("12345627", "Alan", "Pérez", "Romero", new DateTime(2016, 5, 17), "PERR160517STU"));
            alumnos.Add(new Alumno("12345628", "Renato", "González", "Flores", new DateTime(2017, 6, 18), "GONR170618VWX"));
            alumnos.Add(new Alumno("12345629", "César", "Ramírez", "Sánchez", new DateTime(2018, 7, 19), "RAMC180719YZA"));
            alumnos.Add(new Alumno("12345630", "Jimena", "Vargas", "Gómez", new DateTime(2019, 8, 20), "VAGX190820BCD"));
            alumnos.Add(new Alumno("12345631", "Diego", "Martínez", "Pérez", new DateTime(2020, 9, 21), "MARJ200921EFJ"));
            alumnos.Add(new Alumno("12345632", "Abril", "Hernández", "García", new DateTime(2021, 10, 22), "HERA211022GKL"));
            alumnos.Add(new Alumno("12345633", "Javier", "Guzmán", "Torres", new DateTime(2022, 11, 23), "GUZJ221123HNM"));
            alumnos.Add(new Alumno("12345634", "Mariana", "Sánchez", "Castro", new DateTime(2023, 12, 24), "SANC231224PKO"));
            alumnos.Add(new Alumno("12345635", "Eduardo", "González", "Ramírez", new DateTime(2024, 1, 25), "GONR240125QRP"));
            alumnos.Add(new Alumno("12345636", "Abram", "López", "Hernández", new DateTime(2025, 2, 26), "LOPH250226STQ"));
            alumnos.Add(new Alumno("12345637", "Pedro", "García", "Martínez", new DateTime(2026, 3, 27), "GARM260327UVW"));
            alumnos.Add(new Alumno("12345638", "Valeria", "Martínez", "Sánchez", new DateTime(2026, 3, 27), "GARM260327UVW"));
            // Creamos lista de administrativos
            administrativos.Add(new Administrativo("12345", "Ivan", "Gómez", "Pérez", new DateTime(1980, 1, 1), "GOMI800101ABC"));
            administrativos.Add(new Administrativo("12346", "Monserrath", "Rodríguez", "Sánchez", new DateTime(1985, 2, 2), "ROSM850202DEF"));
            administrativos.Add(new Administrativo("12347", "Brayan", "Hernández", "García", new DateTime(1990, 3, 3), "HERB900303GHI"));
            administrativos.Add(new Administrativo("12348", "Alicia", "García", "Pérez", new DateTime(1995, 4, 4), "GARL950404JKL"));
            administrativos.Add(new Administrativo("12349", "Pedro", "Sánchez", "González", new DateTime(2000, 5, 5), "SANG000505MNO"));
            administrativos.Add(new Administrativo("123410", "Manuel", "Pérez", "Martínez", new DateTime(2005, 6, 6), "PERM050606PQR"));
            administrativos.Add(new Administrativo("123411", "Daniel", "Martínez", "Hernández", new DateTime(2010, 7, 7), "MARH100707STU"));
            administrativos.Add(new Administrativo("123412", "Lucio", "González", "García", new DateTime(2015, 8, 8), "GONL150808VWX"));
            administrativos.Add(new Administrativo("123413", "Fernanda", "Ramírez", "Sánchez", new DateTime(2020, 9, 9), "RAMF200909YZA"));
            administrativos.Add(new Administrativo("123414", "Sofía", "Vargas", "Gómez", new DateTime(2025, 10, 10), "VARS251010BCD"));
            administrativos.Add(new Administrativo("123415", "Daniela", "Guzmán", "Pérez", new DateTime(2030, 11, 11), "GUZD301111EFJ"));
            administrativos.Add(new Administrativo("123416", "Carolina", "Sánchez", "Hernández", new DateTime(2035, 12, 12), "SANJ351212GKL"));
            administrativos.Add(new Administrativo("123417", "Roberta", "López", "García", new DateTime(2040, 1, 13), "LOPR400113HNM"));
            administrativos.Add(new Administrativo("123418", "Isabel", "García", "Martínez", new DateTime(2045, 2, 14), "GARJ450214PKO"));
            administrativos.Add(new Administrativo("123419", "Julio", "Hernández", "Sánchez", new DateTime(2050, 3, 15), "HERJ500315QRP"));
            Console.WriteLine("Alumnos");
            foreach (Alumno alumno in alumnos)
            {
                alumno.EnseñarDato();
            }
            Console.WriteLine("Maestros");
            foreach (Maestro maestro in maestros)
            {
                maestro.EnseñarDato();
            }
            Console.WriteLine("Administrativos");
            foreach(Administrativo administrativo in administrativos)
            {
                administrativo.EnseñarDato();
            }
        }
    }
}
