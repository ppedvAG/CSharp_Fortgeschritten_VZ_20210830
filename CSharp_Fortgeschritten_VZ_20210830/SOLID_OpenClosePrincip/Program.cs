using System;

namespace SOLID_OpenClosePrincip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }



    #region BadCode
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
    }


    public class ReportGenerator
    {
        /// <summary>
        /// Report type
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(Employee em)
        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                //Libary für PDF Export
                //Fülllogik us
                // Report generation with employee data in PDF.
            }
        }
    }
    #endregion

    #region Open Close with abstract class 
    public abstract class ReportGeneratorBase //Open (ich biete abstrakt meine Generate-Methode an) 
    {
        public abstract void Generate();
    }

    public class PDFGenerator : ReportGeneratorBase
    {
        //Hier haben wir genug Platz für unsere PDF - Library und allen seinen Funktionen 
        public override void Generate()
        {
            Console.WriteLine("generiere ein PDF");
        }
    } //Close Bereich

    public class CrystalReportsGenerator : ReportGeneratorBase
    {
        //Hier haben wir genug Platz für unsere Crstal Reports - Library und allen seinen Funktionen 


        public override void Generate()
        {
            Console.WriteLine("generiere ein PDF");
        }
    } //Close Bereich
    #endregion


    #region Gute Lösung 2

    public interface IGenerator
    {
        void Generator();
    }

    public class PDFGenerator1 : IGenerator
    {
        public void Generator()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
