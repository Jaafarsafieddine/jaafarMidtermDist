
using lab2;
using System.Xml.Serialization;


List<Student> students = new List<Student>();

XmlSerializer deserializer = new XmlSerializer(typeof(List<Student>));



using (TextReader textReader = new StreamReader(@"C:/Users/jaafa/source/repos/Lab2/Lab2/XMLFile1.xml"))
{
    students = (List<Student>)deserializer.Deserialize(textReader);
}



Student s1 = new Student();
personalinfo p1 = new personalinfo();
faculty f1 = new faculty();
branch b1 = new branch();
branchAdress ba1 = new branchAdress();

s1.firstname = "jaafar";
s1.lastname = "Safieddine";
s1.StudentId = 202010750;
p1.city = "dahye";
p1.streetName = "radouf";
p1.number = 3;
s1.personalAddress = p1;
f1.FacultyId = 2;
f1.Value = "Engineer";
s1.faculty = f1;
b1.branchId = 2;
b1.branchName = "lbne";
s1.branch = b1;
ba1.streetName = "baabda";
ba1.city = "BAABDA";
b1.branchAdress = ba1;

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

XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
TextWriter writer = new StreamWriter(@"C:/Users/jaafa/source/repos/Lab2/Lab2/XMLFile1.xml");
serializer.Serialize(writer, students);