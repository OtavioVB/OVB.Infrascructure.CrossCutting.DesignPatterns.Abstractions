namespace OVB.Infrascructure.CrossCutting.DesignPatterns.Abstractions.Mappings;

public interface IBaseMapping<T> where T : class
{
    public void CreateMap(T entity);
}
