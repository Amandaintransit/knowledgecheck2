using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace KnowledgeCheck2
{
    public class Records
    {
        public int BirthYear { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return "Name:" + FirstName + LastName + "Born: " + BirthYear;
        }

    }

    public class MedicalChart : Records
    {
        public int Weight { get; set; }
        public string Medications { get; set; }
        public override string ToString()
        {
            return ($"Name: {FirstName} {LastName}\nborn: {BirthYear}\nWeight:{Weight}\nMedications: {Medications}");

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;
             
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());
            var recordList = new List<MedicalChart>();
            for (int i = 0; i < numberOfRecords; i++)
            {


                var medicalChart = new MedicalChart();

                Console.WriteLine("What year was patient born?");
                medicalChart.BirthYear = int.Parse(Console.ReadLine());
                Console.WriteLine("What is patient's first name?");
                medicalChart.FirstName = Console.ReadLine();
                Console.WriteLine("What is patient's last name?");
                medicalChart.LastName = Console.ReadLine();
                Console.WriteLine("How much does patient weigh?");
                medicalChart.Weight = int.Parse(Console.ReadLine());
                Console.WriteLine("What medications does patient take?");
                medicalChart.Medications = Console.ReadLine();

                recordList.Add(medicalChart);
            }
            foreach (var medicalChart in recordList)
                Console.WriteLine(medicalChart);
     
        }
    }
    
}
