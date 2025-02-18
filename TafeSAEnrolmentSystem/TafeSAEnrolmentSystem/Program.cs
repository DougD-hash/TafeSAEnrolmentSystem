using TafeSAEnrolmentSystem;

Person myPerson = new Person();
Console.WriteLine(myPerson);

myPerson.PersonName = "John Doe";
myPerson.PersonEmail = "Johndoe@outlook.com";
myPerson.PersonPhoneNumber = "0425356472";
Console.WriteLine("myPerson name: " + myPerson.PersonName);
Console.WriteLine("myPerson email: " + myPerson.PersonEmail);
Console.WriteLine("myPerson phone number: " + myPerson.PersonPhoneNumber);




Console.ReadKey();