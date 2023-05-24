﻿int Lenght, MaxValue, MinValue;
double resultDifference;
Lenght = 6;
MaxValue = 100;
MinValue = 1;

double minInArray = 0;
double maxInArray = 0;


double[] DoubleType = new double[Lenght];

for (int i = 0; i < Lenght; i++)
{
    DoubleType[i] = new Random().NextDouble();
    DoubleType[i] = DoubleType[i] * (MaxValue - MinValue) + MinValue;
    DoubleType[i] = Math.Round(DoubleType[i], 2);
    Console.Write(DoubleType[i] + "; ");
    if (i == 0)
    {
        maxInArray = DoubleType[i];
        minInArray = DoubleType[i];
    }
    if (DoubleType[i] > maxInArray) maxInArray = DoubleType[i];
    if (DoubleType[i] < minInArray) minInArray = DoubleType[i];
            }
Console.WriteLine();

resultDifference = maxInArray - minInArray;
Console.WriteLine($"{maxInArray} - {minInArray} = {resultDifference}");