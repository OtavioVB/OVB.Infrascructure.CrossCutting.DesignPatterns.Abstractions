namespace OVB.Infrascructure.CrossCutting.DesignPatterns.Abstractions.Repositories.Extensions;

public interface IExtensionRepository<T> where T : class
{
    public Task<bool> VerifyEntityExistsAsync(Guid identifier);
}
