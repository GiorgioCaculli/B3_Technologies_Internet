namespace Application.UseCases.Utils
{
    public interface IUpdate<out TO, in TI1, in TI2>
    {
        TO Execute(TI1 source, TI2 destination);
    }
}
