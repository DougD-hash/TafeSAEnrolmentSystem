using TafeSAEnrolmentSystem;

Person myPerson = new Person();
Console.WriteLine(myPerson);

myPerson.PersonName = "John Doe";
myPerson.PersonEmail = "Johndoe@outlook.com";
myPerson.PersonPhoneNumber = "0425356472";
Console.WriteLine("myPerson name: " + myPerson.PersonName);
Console.WriteLine("myPerson email: " + myPerson.PersonEmail);
Console.WriteLine("myPerson phone number: " + myPerson.PersonPhoneNumber);


Address myAddress1 = new Address("58", "Elm Street", "North Adelaide", "5000", "SA");
Person myPerson1 = new Person("Jane Doe", "Janedoe@outlook.com", "0432658412",myAddress1);
Console.WriteLine(myPerson1);

Address myAddress = new Address();
Console.WriteLine(myAddress);
myAddress.StreetNumber = "30";
myAddress.StreetName = "Parliament House";
myAddress.Suburb = "Glenelg";
myAddress.Postcode = "5012";
myAddress.State = "SA";
Console.WriteLine("myAddress Street Number: " + myAddress.StreetNumber);
Console.WriteLine("myAddress Street Name: " + myAddress.StreetName);
Console.WriteLine("myAddress Suburb: " + myAddress.Suburb);
Console.WriteLine("myAddress Postcode: " + myAddress.Postcode);
Console.WriteLine("myAddress State: " + myAddress.State);
Student student1 = new Student(01, "IT", "18/02/2024");
Person myPerson2 = new Person("Mike Smith", "mikesmith@outlook.com", "0423654895", myAddress);
//Testing composition
myPerson2.StudentID = 20;
myPerson2.Program = "IT";
myPerson2.DateRegistered = "2020";
Console.WriteLine(myPerson2);

Subject mySubject = new Subject();
mySubject.SubjectCode = "ICT451";
mySubject.SubjectName = "Advanced Programming";
mySubject.SubjectCost = 300.50;
Console.WriteLine("mySubject code : " + mySubject.SubjectCode);
Console.WriteLine("mySubject name: " + mySubject.SubjectName);
Console.WriteLine("mySubject cost: " + mySubject.SubjectCost);
Subject mySubject1 = new Subject("ICT509", "Cybersecurity", 3000.20);
Console.WriteLine(mySubject1);
Enrolment myEnrolment1 = new Enrolment();
myEnrolment1.EnrolmentDate = "17/05/2024";
myEnrolment1.Grade = "C";
myEnrolment1.Semester = "2";
Console.WriteLine("myEnrolment1 enrolment date: " + myEnrolment1.EnrolmentDate);
Console.WriteLine("myEnrolment1 grade: " + myEnrolment1.Grade);
Console.WriteLine("myEnrolment1 semester: " + myEnrolment1.Semester);

Enrolment myEnrolment = new Enrolment("10/02/2025","B","1", mySubject);
Console.WriteLine(myEnrolment);






Console.ReadKey();