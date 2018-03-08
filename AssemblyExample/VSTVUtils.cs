using System;

namespace AssemblyExample
{
    class VSTVUtils
    {
        public static double[] NormalizedRows = new double[]{
            1.00, 1.06, 1.12, 1.18,
            1.25, 1.32, 1.40, 1.50,
            1.60, 1.70, 1.80, 1.90,
            2.00, 2.12, 2.24, 2.36,
            2.50, 2.65, 2.80, 3.00,
            3.15, 3.35, 3.55, 3.75,
            4.00, 4.25, 4.50, 4.75,
            5.00, 5.30, 5.60, 6.00,
            6.30, 6.70, 7.10, 7.50,
            8.00, 8.50, 9.00, 9.50,
            10.00,
        };

        public static double NormalizeNumber(double number, int row, int digest)
        {
            double numberStart = number;
            int power = 0;

            if (number > 10)
            {
                while (numberStart > 10)
                {
                    power++;
                    numberStart /= 10.0;
                }
            }
            else if (number < 1)
            {
                while (numberStart < 1)
                {
                    power--;
                    numberStart *= 10.0;
                }
            }
            double result = 0.0;
            double min = numberStart;

            for (int a = 0; a < row; a++)
            {
                double curr = Math.Abs(numberStart - NormalizedRows[a * 40 / row]);
                if (curr <= min)
                {

                    min = curr;
                    result = NormalizedRows[a * 40 / row];
                }
            }
            result *= Math.Pow(10, (double)power);
            return Math.Round(result, digest);
        }
    }
}
