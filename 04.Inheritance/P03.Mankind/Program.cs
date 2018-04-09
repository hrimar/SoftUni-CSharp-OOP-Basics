using System;

class Program
{
    static void Main()      // 100/100 - пак я виж - има полезни неща!
    {
        try
        {
            var studentInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
             var workerInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Student student = null;
            if (studentInput.Length == 3)
            {
                var sfirstName = studentInput[0];
                var slastName = studentInput[1];
                var faultyNumber = studentInput[2];

                student = new Student(sfirstName, slastName, faultyNumber);
            }

            Worker worker = null;
            if (workerInput.Length == 4)
            {
                var firstName = workerInput[0];
                var lastName = workerInput[1];
                decimal salary = decimal.Parse(workerInput[2]);
                double workHoursPerDay = double.Parse(workerInput[3]);

                worker = new Worker(firstName, lastName, salary, workHoursPerDay);
            }
            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker.ToString());
           
        }
        catch (ArgumentException ar)
        {
            Console.WriteLine(ar.Message);
        }

    }
}

