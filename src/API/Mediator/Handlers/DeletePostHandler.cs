﻿namespace API.Mediator.Handlers;
public class DeletePostHandler(IRepository<Post> postRepository) : IRequestHandler<DeletePost>
{
    public async Task Handle(DeletePost request, CancellationToken cancellationToken)
    {
        await postRepository.DeleteAsync(request.Id);
    }
}