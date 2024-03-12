using System;
using System.Linq;

class Methods
{
    public void Greet() => Console.WriteLine("Hey, there!");

   public void Greet(string greeting)=> Console.WriteLine($"{greeting}, there!"); //string interpolation

    public  float CalculateBMI(float weightInkg, float heightInFt)
    {
        var heightInM = heightInFt * 0.3048f;
        var bmi = weightInkg/(heightInM * heightInM);
        return bmi;
    }
    public double GetMax(params double[] numbers) =>numbers.Max();

    public (int ,int) GetMinMax(params int[] numbers){
        var smallest = numbers.Min();
         var highest  = numbers.Max();
          return (smallest ,highest);

    }
    
    }