using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
    Email = "Annemarie@cptc.edu",
    FullName = "Annemarie Smith",
    OfficeLocation = "817 Rm 150"
};

Student student1 = new Student()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(2000, 3, 20),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "5555554781",
    SchoolEmail = "Homer.Simpson@students.cptc.edu"
};

Console.WriteLine($"Student: {student1.FirstName} has {student1.AssignedAdvisor.FullName}");
