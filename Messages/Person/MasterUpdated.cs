namespace SpaService.Domain.Messages.Person
{
    public class MasterUpdated
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
