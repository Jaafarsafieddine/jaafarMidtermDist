
using Advanced_lab2;
using System.Xml.Serialization;


List<Student> students = new List<Student>();

XmlSerializer deserializer = new XmlSerializer(typeof(List<Student>));

TextReader reader = new StreamReader(@"C:/Users/jaafa/source/repos/Advanced_lab2/Advanced_lab2/XMLFile1.xml");

Student obj = (Student)deserializer.Deserialize(reader);​

reader.Close();


Student s1 = new Student();
s1.firstname = "jaafar";
s1.lastname = "Safieddine";
s1.StudentId = 202010750;
s1.personalAddress.city = "dahye";
s1.personalAddress.streetName = "radouf";
s1.faculty.FacultyId = 2;
s1.faculty.Value = "Engineer";
s1.personalAddress.number = 3;
s1.branch.branchId = 2;
s1.branch.branchName = "lbne";
s1.branch.branchAdress.streetName = "baabda";
s1.branch.branchAdress.city = "BAABDA";

students.Add(s1);

foreach (var student in students)
{
    Console.WriteLine($"Student ID: {student.StudentId}");
    Console.WriteLine($"First Name: {student.firstname}");
    Console.WriteLine($"Last Name: {student.lastname}");
    Console.WriteLine($"Address: {student.personalAddress.streetName}, {student.personalAddress.city}");
    Console.WriteLine($"Faculty ID: {student.faculty.FacultyId}, Name: {student.faculty.Value}");
    Console.WriteLine("Branch ID: " + student.branch.branchId);
    Console.WriteLine("Branch branchName: " + student.branch.branchName);
    Console.WriteLine("Branch city: " + student.branch.branchAdress.city);
    Console.WriteLine("Branch number: " + student.branch.branchAdress.number);
    Console.WriteLine("Branch streetName: " + student.branch.branchAdress.streetName);


    Console.WriteLine();
}