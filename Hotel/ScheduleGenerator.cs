using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel
{
    internal class Day
    {
        public List<StaffEntity> receptions = new List<StaffEntity>();
        public List<StaffEntity> labors = new List<StaffEntity>();
        public List<ManagerEntity> managers = new List<ManagerEntity>();
    }

    class RequiredStaffShift
    {
        public int total_manager;
        public int total_labor;
        public int total_reception;
    }

    internal class ScheduleGenerator
    {
        public static List<Day> generate(List<ManagerEntity> managers, List<StaffEntity> receptions, List<StaffEntity> labors)
        {
            int n = 42;
            List<Day> schedule = new List<Day>();
            for (int i = 0; i < n; i++)
            {
                schedule.Add(new Day());
            }

            int[] dayShift =
            {
                1, 2, 3,
                7, 8, 9,
                13, 14, 15,
                19, 20, 21,
                25, 26, 27
            };

            int[] nightShift =
            {
                4, 5, 6,
                10, 11, 12,
                16, 17, 18,
                22, 23, 24,
                28, 29, 30,
            };

            int[] weekenShifts =
            {
                31, 32, 33,
                34, 35, 36,
                37, 38, 39,
                40, 41, 42
            };

            int count = 0;
            foreach (ManagerEntity manager in managers)
                for (int i = 0; i < n; i++)
                {
                    // update dayshift
                    if (i % 6 == 0) count = 0;

                    // If is Shift 1
                    Day currDay = schedule[i];
                    if (dayShift.Contains(i + 1))
                    {
                        // manager
                        if (currDay.managers.Count < 1 && count < 2)
                        {
                            currDay.managers.Add(manager);
                            count++;
                        }
                    }
                    else // Shift 2
                    {
                        if (currDay.managers.Count < 1 && count < 2)
                        {
                            currDay.managers.Add(manager);
                            count++;
                        }
                    }
                }

            count = 0;
            foreach (StaffEntity reception in receptions)
                for (int i = 0; i < n; i++)
                {
                    // update dayshift
                    if (i % 6 == 0) count = 0;

                    // If is Shift 1
                    Day currDay = schedule[i];
                    if (dayShift.Contains(i + 1))
                    {
                        // manager
                        if (currDay.receptions.Count < 2 && count < 2)
                        {
                            currDay.receptions.Add(reception);
                            count++;
                        }
                    }
                    else // Shift 2
                    {
                        if (currDay.receptions.Count < 1 && currDay.managers.Count == 0 && count < 2)
                        {
                            currDay.receptions.Add(reception);
                            count++;
                        }
                    }
                }

            count = 0;
            foreach (StaffEntity labor in labors)
                for (int i = 0; i < n; i++)
                {
                    // update dayshift
                    if (i % 6 == 0) count = 0;

                    // If is Shift 1
                    Day currDay = schedule[i];
                    if (dayShift.Contains(i + 1))
                    {
                        if (currDay.labors.Count < 4 && count < 2)
                        {
                            currDay.labors.Add(labor);
                            count++;
                        }
                    }
                    else
                    if (weekenShifts.Contains(i + 1)) // Weeken shift
                    {
                        if (currDay.labors.Count < 3 && count < 2)
                        {
                            currDay.labors.Add(labor);
                            count++;
                        }
                    }
                    else
                    if (nightShift.Contains(i + 1))
                    {
                        if (currDay.labors.Count < 1 && count < 2)
                        {
                            currDay.labors.Add(labor);
                            count++;
                        }
                    }
                }

            return schedule;
        }
    }
}
