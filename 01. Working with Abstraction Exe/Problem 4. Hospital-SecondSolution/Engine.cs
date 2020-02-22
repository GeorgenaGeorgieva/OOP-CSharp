namespace HospitalSecondSolution
{
    using System;
    using System.Linq;
     
    public class Engine
    {
        private Hospital hospital;

        public Engine()
        {
            this.hospital = new Hospital();
        }

        public void Run()
        {
            var command = Console.ReadLine();

            while (command != "Output")
            {
                var arguments = command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var departament = arguments[0];
                var firstName = arguments[1];
                var secondName = arguments[2];
                var patient = arguments[3];
                var doctorFullName = firstName + " " + secondName;

                this.hospital.AddDoctor(firstName, secondName);
                this.hospital.AddDepartment(departament);
                this.hospital.AddPatient(departament, doctorFullName, patient);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                var arguments = command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (arguments.Length == 1)
                {
                    var depatrmentName = arguments[0];
                    var department = this.hospital
                        .Departments
                        .FirstOrDefault(de => de.Name == depatrmentName);

                    Console.WriteLine(department);
                }
                else
                {
                    var departmentName = arguments[0];
                    var department = this.hospital
                        .Departments
                        .FirstOrDefault(de => de.Name == departmentName);

                    bool isRoom = int.TryParse(arguments[1], out int resultRoom);

                    if (isRoom)
                    {
                        var currentRoom = department.Rooms[resultRoom - 1];
                        Console.WriteLine(currentRoom);
                    }
                    else
                    {
                        var firstName = arguments[0];
                        var lastName = arguments[1];

                        var doctorFullName = firstName + " " + lastName;

                        var doctor = this.hospital
                            .Doctors
                            .FirstOrDefault(d => d.FullName == doctorFullName);

                        Console.WriteLine(doctor);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}


