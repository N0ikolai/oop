using System;
using System.Collections.Generic;

public class TempAnaliz
{
    private const int MonthsInYear = 12; 
    private const int DaysInMonth = 30;   
    private LinkedList<double> monthlyTemp;

    public TempAnaliz()
    {
        monthlyTemp = new LinkedList<double>();
    }

    public void InputMonthlyTemp()
    {
        for (int i = 0; i < MonthsInYear; i++)
        {
            Console.Write($"Enter average temp for month {i + 1}: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            monthlyTemp.AddLast(temp);
        }
    }


    public double Culc()
    {
        double sum = 0;
        int count = 0;

        foreach (var temp in monthlyTemp)
        {
            sum += temp;
            count++;
        }
        return sum / count;
    }

    public double[,] GenDailyTemp()
    {
        double[,] temp = new double[MonthsInYear, DaysInMonth];
        Random random = new Random();

        for (int i = 0; i < MonthsInYear; i++)
        {
            for (int j = 0; j < DaysInMonth; j++)
            {
                temp[i, j] = random.Next(-10, 36);
            }
        }
        return temp;
    }

    public double[] CalculateMonthlyAverages(double[,] temp)
    {
        double[] averages = new double[MonthsInYear];

        for (int month = 0; month < MonthsInYear; month++)
        {
            double sum = 0;
            for (int day = 0; day < DaysInMonth; day++)
            {
                sum += temp[month, day];
            }
            averages[month] = sum / DaysInMonth;
        }

        return averages;
    }
}