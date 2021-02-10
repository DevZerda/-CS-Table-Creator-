# -CS-Table-Creator-
Table creator returning as string for Consoles/Terminals
        
            HOW TO USE

    int[] fag = { 50, 50 };
    Creator.set_columns(fag);
    string[] test = { "Location Type", "Location" };
    Console.WriteLine(Creator.createHeader(test));
    for (int i = 0; i < 10; i++)
    { // Making a row '10' times
           string[] skid = { i.ToString(), "batman_343" };
            Console.WriteLine(Creator.CreateRow(skid));
            i++;
    }
            
            
