namespace Modul3HomeWork4
{
    public class Task1
    {
        public Task1()
        {
            ListSumHelper += (x, y) => TryCatch(Sum, x, y);
            ListSumHelper += (x, y) => TryCatch(Sum, x, y);
        }

        public delegate int SumHelper(int x, int y);

        public event SumHelper ListSumHelper;

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
    }
}
