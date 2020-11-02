namespace API.Services
{
    public interface IArrayService
    {
        int Sum(int[] intArray);

        int Multiply(int[] intArray);

        int[] Double(int[] intArray);
    }
}