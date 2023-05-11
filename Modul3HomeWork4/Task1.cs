namespace Modul3HomeWork4
{
    public class Task1
    {
        public Task1()
        {
            ListSumHandler += Sum;
            ListSumHandler += Sum;
        }

        public delegate int SumHandler(int x, int y);

        public event SumHandler ListSumHandler;

        public int GetSumResults(int first, int second)
        {
            try
            {
                int result = 0;
                var array = ListSumHandlerResults(first, second);

                foreach (var item in array)
                {
                    result += item;
                }

                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private List<int> ListSumHandlerResults(int first, int second)
        {
            var result = new List<int>();

            if (ListSumHandler != null)
            {
                var delegateList = ListSumHandler.GetInvocationList();

                for (int i = 0; i < delegateList.Length; i++)
                {
                    var delegat = delegateList[i] as SumHandler;
                    result.Add(delegat.Invoke(first, second));
                }
            }

            return result;
        }

        private static int Sum(int x, int y) => x + y;
    }
}
