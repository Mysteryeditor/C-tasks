using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    public partial struct Task3
    {
        int option, present, absent;
        SortedList<string, string> trainees = new SortedList<string, string>();



        public partial void AttendaceCalculation()
        {
            trainees.Add("Srikanth", "Present");

            string editTrainee, editAttendance;

            while (option != 7)
            {
                Console.WriteLine("***CGVAK ATTENDANCE SYSTEM***");
                Console.WriteLine("1.View Attendance");
                Console.WriteLine("2.Mark Attendance");
                Console.WriteLine("3.Add Trainee");
                Console.WriteLine("4.Remove Trainee");
                Console.WriteLine("5.View Present");
                Console.WriteLine("6.View Absent");
                Console.WriteLine("7.Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("---Trainee---Status---");
                        foreach (var item in trainees)
                        {
                            Console.WriteLine("   " + item.Key + "   " + item.Value);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter the Trainee name");
                        editTrainee = Console.ReadLine();

                        if (trainees.ContainsKey(editTrainee))
                        {
                            Console.WriteLine("Mark Attendance(Present/Absent)");
                            editAttendance = Console.ReadLine();

                            trainees.Remove(editTrainee);
                            trainees.Add(editTrainee, editAttendance);

                            Console.WriteLine("***Edited SuccessFully***");

                        }

                        else { Console.WriteLine("Trainee Does Not Exist"); }
                        break;

                    case 3:
                        Console.WriteLine("Enter Name");
                        editTrainee = Console.ReadLine();

                        if (trainees.ContainsKey(editTrainee))
                        {
                            Console.WriteLine("Trainee Already Exists");

                        }

                        else
                        {
                            Console.WriteLine("Mark Attendance(Present/Absent)");
                            editAttendance = Console.ReadLine();
                            trainees.Add(editTrainee, editAttendance);
                            Console.WriteLine("***Trainee Added SuccessFully");
                        }

                        break;


                    case 4:
                        Console.WriteLine("Enter Name To Remove");
                        editTrainee = Console.ReadLine();
                        if (trainees.ContainsKey(editTrainee))
                        {
                            trainees.Remove(editTrainee);
                            Console.WriteLine("***Deleted SuccessFully***");

                        }

                        else { Console.WriteLine("Trainee Does not Exist"); }
                        break;

                    case 5:
                        foreach (var trainee in trainees)
                        {
                            int count = 0;
                            if (trainee.Value.ToLower() == "present")
                            {
                                Console.WriteLine("---Trainee---Status---");
                                foreach (var item in trainees)
                                {
                                    count++;
                                    Console.WriteLine("   " + item.Key + "   " + item.Value);
                                }
                                Console.WriteLine("Total Present = " + count);
                                Console.WriteLine();

                            }
                        }
                        break;
                    case 6:
                        foreach (var trainee in trainees)
                        {
                            int count = 0;
                            if (trainee.Value.ToLower() == "absent")
                            {
                                Console.WriteLine("---Trainee---Status---");
                                foreach (var item in trainees)
                                {
                                    count++;
                                    Console.WriteLine("   " + item.Key + "   " + item.Value);
                                }
                                Console.WriteLine("Total Absent = " + count);
                                Console.WriteLine();

                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("Thank You");
                        break;

                }

            }





        }
    }
}
