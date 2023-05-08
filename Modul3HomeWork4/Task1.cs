namespace Modul3HomeWork4
{
    public class Task1
    {
        public Task1()
        {
            ListSumHandler += (x, y) => TryCatch(Sum, x, y);
            ListSumHandler += (x, y) => TryCatch(Sum, x, y);
        }

        public delegate int SumHandler(int x, int y);

        public event SumHandler ListSumHandler;

        public static int Sum(int x, int y) => x + y;

        public int TryCatch(Func<int, int, int> func, int first, int second)
        {
            try
            {
                var result = func(first, second);
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int GetSum(int first, int second) => ListSumHandler(first, second);
    }
}
