using System;

// Exceeded requirements by adding full save/load support for all goal types,
// including checklist progress and bonus data.
class Program
{
    static void Main(string[] args)
    {
         
        Menu menu = new Menu();
        Goals goals = new Goals();

        bool running = true;

        while (running)
        {
            int option = menu.DisplayMainMenu();

            if (option == 1)
            {
                int goalType = menu.DisplayCreateGoalMenu();

                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateGoal();
                    goals.AddGoal(simpleGoal);
                }
                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal();
                    goals.AddGoal(eternalGoal);
                }
                else if (goalType == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.CreateGoal();
                    goals.AddGoal(checklistGoal);
                }
            }
            else if (option == 2)
            {
                goals.DisplayGoalList();
            }
            else if (option == 3)
            {
                goals.RecordGoalEvent();
            }
            else if (option == 4)
            {
                goals.DisplayScore();
            }
            else if (option == 5)
            {
                goals.SaveFile();
            }
            else if (option == 6)
            {
                goals.LoadFile();
            }
            else if (option == 7)
            {
                running = false;
            }
        }
    

    }
}
