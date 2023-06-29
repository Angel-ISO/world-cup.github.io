﻿using fifaWorldCup_app.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Controller controller = new Controller();
        bool isRunApp = true;
        int opcion =0;
        do{
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1.Registro de equipos\n2.Ver equipos\n3.Registro Personas\n4.Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion){
                case 1:
                    controller.CreateTeams();
                    break;
                case 2:
                    ImprimirValores(controller.AllCollection());
                    break;
                case 3:
                   RegistrarPersona();
                    break;
                case 4:
                    isRunApp=false;
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error opcion no Valida");
                    break;

            }
        }while (isRunApp);
    
    }
    private static void ImprimirValores(IEnumerable<Teams> teams)
    {
        Console.WriteLine(teams.Count());
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("{0,-20} {1,20}", "Cod. Equipo", "Nombre Equipo");
        foreach (Teams team in teams)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-20} {1,17}", team.IdTeam,team.NameTeam);

        }
        Console.ReadKey();
    }


    private static void RegistrarPersona()
{
     Player player = new Player();
     TeamTechnical teamTechnical = new TeamTechnical();
     TeamMedical teamMedical = new TeamMedical();


    Console.WriteLine("Ingrese el tipo de persona a registrar (jugador, tecnico o medico):");
    string tipoPersona = Console.ReadLine();

    switch (tipoPersona.ToLower())
    {
        case "jugador":
           player.RegistroPlayer();
            break;

        case "tecnico":
          teamTechnical.RegistroTechTeam();
            break;

        case "medico":
           teamMedical.RegistroMedicalTeam();
            break;

        default:
            Console.WriteLine("Tipo de persona no válido");
            break;
    }
}

}