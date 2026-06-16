public void LoadGoals(string fileName)
{
    string[] lines = File.ReadAllLines(fileName);

    _score = int.Parse(lines[0]);
    _goals.Clear();

    for (int i = 1; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split('|');

        if (parts[0] == "SimpleGoal")
        {
            // recreate SimpleGoal
        }
        else if (parts[0] == "EternalGoal")
        {
            // recreate EternalGoal
        }
        else if (parts[0] == "ChecklistGoal")
        {
            // recreate ChecklistGoal
        }
    }
}
