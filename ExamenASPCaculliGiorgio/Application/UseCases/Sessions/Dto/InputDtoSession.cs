namespace Application.UseCases.Sessions.Dto
{
    public class InputDtoSession
    {
        public int IdUtilisateur { get; set; }
        public int IdParcours { get; set; }
        public string TypeSession { get; set; }
        public int TempsMinutes { get; set; }
    }
}
