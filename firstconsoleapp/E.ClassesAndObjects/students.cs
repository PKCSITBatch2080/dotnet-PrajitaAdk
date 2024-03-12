class Student{
public string name;
byte rollnumber;    //here field is used
public string address{get; set;} //auto implemented property

DateTime dob;

public int MyProperty { get; set; }

public Student(){     //by default this contruction is called ( default construction of class Student)
                    // default constructor
}

public Student(string n , byte rn){    //parameterized constructor
    name = n;
    Rollnumber = rn; //property is used not field
}

public Student(string n , byte rn, DateTime dateOfBIrth){    //parameterized constructor
    name = n;
    Rollnumber = rn; //property is used not field
    dob = dateOfBIrth;
}
public byte Rollnumber{

    get{
        return rollnumber;
    }                                  // full  property as it has get and set
    set                                 //auto implemented propeerty
    {
        if (value <= 100)
        {
            rollnumber = value;
        }
    }
}

public virtual void DisplayInfo()
{
    Console.WriteLine($"Student Name: {name}");
    Console.WriteLine($"Student Name: {rollnumber}");     //method of the class Student
    Console.WriteLine($"Student Name: {address}");
    Console.WriteLine($"Student Name: {dob}");

}

public DateTime Dob {get;}   //read only property it cannot write



}