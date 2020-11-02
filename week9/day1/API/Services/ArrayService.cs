namespace API.Services
{
    public class ArrayService : IArrayService
    {
        public int Sum(int[] intArray)
        {
            var result = 0;

            foreach (var integer in intArray) result += integer;

            return result;
        }

        public int Multiply(int[] intArray)
        {
            var result = 1;

            foreach (var integer in intArray) result *= integer;

            return result;
        }

        public int[] Double(int[] intArray)
        {
            int[] result = new int[intArray.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = intArray[i] * 2;
            }

            return result;
        }
    }
}