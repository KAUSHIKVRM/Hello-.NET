using System;
class Student
{
    int stu_roll;
    string stu_name;

    public int ID   //property must be public
    {
        get
        {
            return stu_roll;
        } 
        set
        {
            stu_roll=value;//automaticall value will be set to the returned value
        }
    }
    public string Name
    {
        get
        {
            return stu_name;
        }
        set
        {
            stu_name=value;
        }
    }
    public void Display()
    {
        Console.WriteLine(stu_name+" "+stu_roll);
    }
}
class College
{
    static void Main()
    {
        Student stu=new Student();
        stu.ID=478;
        stu.Name="Kaushik Verma";
        Console.WriteLine(stu.ID+" "+stu.Name);
        stu.Display();
    }
}