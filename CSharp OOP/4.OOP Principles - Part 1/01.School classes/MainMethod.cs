//We are given a school.
//*In the school there are classes of students.
//*Each class has a set of teachers.
//*Each teacher teaches a set of disciplines.
//*Students have name and unique class number.
//*Classes have unique text identifier.
//*Teachers have name.
//*Disciplines have name, number of lectures and number of exercises.
//*Both teachers and students are people. 
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their attributes and operations,
//encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace _01.School_classes
{
    using System;
    using System.Collections.Generic;

    class MainMethod
    {
        static void Main(string[] args)
        {
            Discipline math = new Discipline("Mathematics", 18, 102);
            Discipline english = new Discipline("English", 23, 270);
            Discipline fvs = new Discipline("FVS",12,24);
            Discipline outdoor = new Discipline("Outdoor",12,24);

            Teacher nedqlkova = new Teacher("Nedqlkova",new List<Discipline>(){math});
            Teacher vancheto = new Teacher("Vancheto",new List<Discipline>(){english});
            Teacher shiperkata = new Teacher("Shiperkata",new List<Discipline>(){fvs,outdoor});
            Teacher kacarska = new Teacher("Kacarska");

            Student vancho = new Student("Vankata", 24);
            Student iliicho = new Student("Iliq", 12);

            Class a = new Class("a", new List<Student>(){iliicho},new List<Teacher>() { nedqlkova, vancheto });
            Class b = new Class("b", new List<Student>(){iliicho, vancho}, new List<Teacher>() { nedqlkova, vancheto, shiperkata, kacarska});
            Class c = new Class("c", new List<Student>(){vancho}, new List<Teacher>() { kacarska });

            School botev = new School(new List<Class>() { a, b, c });
              
        }
    }
}
