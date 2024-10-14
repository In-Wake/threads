namespace Test
{
    public class RunSort
    {
        public void Run(int[] arr)
        {
            //call cpp TrySZSort - quicksort
            Array.Sort(arr);
            Array.Reverse(arr);
        }
    }

}
