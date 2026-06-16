public void SaveGoals(string fileName)
{
    using (StreamWriter output = new StreamWriter(fileName))
    {
        output.WriteLine(_score);

        foreach (Goal goal in _goals)
        {
            output.WriteLine(goal.GetSaveString());
        }
    }
}