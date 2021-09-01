using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LinqAndLambdaSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> persons = new List<Person>()
            {
                new Person {Id=1, Age=37, Vorname="Kevin", Nachname="Winter"},
                new Person {Id=2, Age=29, Vorname="Hannes", Nachname="Preishuber"},
                new Person {Id=3, Age=19, Vorname="Scott", Nachname="Hunter"},

                new Person {Id=4, Age=21, Vorname="Scott", Nachname="Hanselmann"},
                new Person {Id=5, Age=45, Vorname="Daniel", Nachname="Roth"},
                new Person {Id=6, Age=50, Vorname="Bill", Nachname="Gates"},

                new Person {Id=7, Age=70, Vorname="Newton", Nachname="King"},
                new Person {Id=8, Age=40, Vorname="Andre", Nachname="R"},
                new Person {Id=9, Age=60, Vorname="Petra", Nachname="Musterfrau"},
            };

            //Linq Statement

            IList<Person> linqStatementResult = (from p in persons
                                                 where p.Age >= 40 && p.Age <= 50
                                                 orderby p.Nachname
                                                 select p).ToList();


            // Linq Funktionen (Where, OrderBy 
            // LAMBDA - Expression: p => p.Age >= 40 && p.Age <= 50
            IList<Person> people = persons.Where(p => p.Age >= 40 && p.Age <= 50)
                                          .OrderBy(o => o.Nachname)
                                          .ToList();

            //Altersduchschnitt ermitteln

            double altersdurchschnitt = persons.Average(a => a.Age);

            //Alle Mitarbeiter über 40 -> wird der Altersdurchschnitt ermittelt
            double altersdurchschnitt2 = persons.Where(p => p.Age > 40)
                                                .Average(a => a.Age);

            double gesamtAlterAllerPersonen = persons.Sum(a => a.Age);
            
            
            //Single
            Person selectedPerson = persons.Single(p => p.Id == 4);

            //SingleOrDefault
            Person defaultPersonResult = persons.SingleOrDefault(p => p.Id == 10);

            if (persons.Count != 0)
            {
                //Personen Liste besitzt Einträge
            }
            int count = persons.Count(c => c.Age < 40);
               

            if (persons.Any())
            {
                //Personen Liste besitzt Einträge
            }

            if (persons.Any(a=>a.Age==20))
            {

            }

            //Pagging wird im Service - Layer verwendet. (Layer-Architekturen)  -> WebAPI, grpc, WCF 
            //Bei keiner Layer - Achritektur -> DataAccess Layer 

            //Parameter Pagging:
            //  -> Seiten-Index
            //  -> Anzahl der Einträge auf einer Seite 

            int pagingNumber = 1; //Aktuell Seite 
            int pagingSize = 3; //Anzahl der Elemente, die auf einer Seite angezeigt werden


            //Linq stellt Pagging subfunktion bereit -> Skip / Take

            IList<Person> ergebnisseSeite1 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();

            //Seite 2
            pagingNumber = 2;
            IList<Person> ergebnisSeite2 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();


            //Seite 3
            pagingNumber = 3;
            IList<Person> ergebnisSeite3 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }
}
