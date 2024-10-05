namespace UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class RemoveBrandCommand
    {
        public RemoveBrandCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
