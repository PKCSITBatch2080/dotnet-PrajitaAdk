//LINQ - Language Integrated Query
using System.Linq;

class LINQLearner {
    void Learn()
    {
        int[] numbers = [3, 4, 5, 10, 15, 17 , 19, 20, 37, 45, 77, 101, 107];
        List<string> names = ["Prajita", "Sona", "Prakriti", "Anupa", "Reshma", "Samikshya"];

        var s1 = new Student("Prajita", 16, new DateTime(2001,03,24));
        var s2 = new Student("Sona", 20, new DateTime(2001,02,16));
        var s3 = new Student("Prakriti", 16, new DateTime(2000,03,22));
        var s4 = new Student("Anupa", 16, new DateTime(2000,07,11));
        var s5 = new Student("Reshma", 16, new DateTime(2000,11,05));

        List<Student> students = [s1, s2, s3, s4, s5];

        //Get odd numbers from numbers
        var oddNumbers = numbers.Where(number => number % 2 == 1); //Lambda Expression

        //Get squares of all items in "numbers"
        var squares = numbers.Select(x => x * x);

        //Get squares of even numbers //meyhod syntax
        var evenNumbersSquare = numbers.Where(y => y % 2 == 0).Select(z => z * z);

        //Query syntax
        evenNumbersSquare = from x in numbers //from is contextual keyword
            where x % 2 == 0 
            select x * x;

        //Get all names initials
        var initials = names.Select(name => name[0]); // ["P", "S", "P", "A", "R", "S"]

        //Order names in ascending order
        var namesOrdered = names.OrderBy(x => x);

        //Find students with name starting with "S"
        var sStudents = students.Where(student => student.name.ToLower().StartsWith('s'));

        //Group students by birth month
        var dobGroups = students.GroupBy(student => student.Dob.Month);

        //Get youngest student
        var youngest = students.OrderByDescending(x => x.Dob).First();
        youngest = students.MaxBy(x => x.Dob);
        // youngest = students.FirstOrDefault(x => DateTime.Now - x.Dob);

        Console.WriteLine(oddNumbers);
    }
}