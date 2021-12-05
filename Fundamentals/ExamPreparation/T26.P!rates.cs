using System;
using System.Collections.Generic;
using System.Linq;

namespace T26.P_rates
{
    class Course
    {
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, Course>();
            string sails = Console.ReadLine();

            while (sails != "Sail")
            {
                string[] currSail = sails.Split("||");
                string city = currSail[0];
                if (!courses.ContainsKey(city))
                {
                    Course currCourse = new Course();
                    currCourse.Population = int.Parse(currSail[1]);
                    currCourse.Gold = int.Parse(currSail[2]);
                    courses.Add(city, currCourse);
                }
                else
                {
                    courses[city].Population += int.Parse(currSail[1]);
                    courses[city].Gold += int.Parse(currSail[2]);
                }
                sails = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currCmd = command.Split("=>");
                //"Plunder=>{town}=>{people}=>{gold}"
                if (currCmd[0] == "Plunder")
                {
                    string town = currCmd[1];
                    int people = int.Parse(currCmd[2]);
                    int gold = int.Parse(currCmd[3]);
                    if (courses.ContainsKey(town))
                    {
                        courses[town].Population -= people;
                        courses[town].Gold -= gold;
                        if (courses[town].Population > 0 && courses[town].Gold > 0)
                        {
                            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        }
                        else
                        {
                            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                            Console.WriteLine($"{town} has been wiped off the map!");
                            courses.Remove(town);
                        }
                    }
                }
                //"Prosper=>{town}=>{gold}"
                else if (currCmd[0] == "Prosper")
                {
                    string town = currCmd[1];
                    int gold = int.Parse(currCmd[2]);
                    if (courses.ContainsKey(town))
                    {
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");                            
                        }
                        else
                        {
                            courses[town].Gold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {courses[town].Gold} gold.");
                        }
                    }
                }
                command = Console.ReadLine();
            }

            courses = courses.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);

            if (courses.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {courses.Count} wealthy settlements to go to:");
                foreach (var course in courses)
                {
                    Console.WriteLine($"{course.Key} -> Population: {course.Value.Population} citizens, Gold: {course.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
