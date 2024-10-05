using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            await _repository.UpdateAsync(new Banner
            {
                BannerID = command.BannerID,
                Description = command.Description,
                Title = command.Title,
                VideoDescription = command.VideoDescription,
                VideoUrl = command.VideoUrl

            });
        }
    }
}
