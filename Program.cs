using (ConsoleAppDBContext db = new ConsoleAppDBContext())
{
    // User user1 = new User(){
    //     Age = 12,
    //     Id = 1,
    //     Name = "Name1",
    //     Position = "Position1"
    // };

    // db.Users.Add(user1);
    // db.SaveChanges();
    var users = db.Users.ToList();
    foreach (User us in users)
        Console.WriteLine($"{us.Id}.{us.Name} - {us.Age}");
    // var user = db.Users.FirstOrDefault();
    // db.Users.Remove(user);
    // db.SaveChanges();
}
