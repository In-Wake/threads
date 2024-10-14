namespace Test
{
    public class StandartDeviation
    {
        public double Run(List<double> values)
        {
            var sum = values.Sum();
            var count = values.Count;
            var m = sum / count;
            var a2 = values.Aggregate(0d, (acc, v) => acc + Math.Pow(v - m, 2)) / count;
            var a = Math.Sqrt(a2);
            return a;
        }
    }
}


