namespace SpaService.Domain.Messages.Person
{
    public class ClientUpdated
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
