using System;
using System.Collections.Generic;

class User
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public User Next;

    public User(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMediaSystem
{
    private User head;

    public void AddUser(int userID, string name, int age)
    {
        User newUser = new User(userID, name, age);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            User temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }
    }

    public void AddFriendConnection(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 != null && user2 != null)
        {
            if (!user1.FriendIDs.Contains(userID2)) user1.FriendIDs.Add(userID2);
            if (!user2.FriendIDs.Contains(userID1)) user2.FriendIDs.Add(userID1);
        }
    }

    public void RemoveFriendConnection(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);
        }
    }

    public List<int> FindMutualFriends(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        List<int> mutualFriends = new List<int>();
        if (user1 != null && user2 != null)
        {
            foreach (int friendID1 in user1.FriendIDs)
            {
                if (user2.FriendIDs.Contains(friendID1))
                {
                    mutualFriends.Add(friendID1);
                }
            }
        }
        return mutualFriends;
    }

    public void DisplayAllFriends(int userID)
    {
        User user = FindUserByID(userID);
        if (user != null)
        {
            Console.WriteLine(user.Name + "'s Friends:");
            foreach (int friendID in user.FriendIDs)
            {
                User friend = FindUserByID(friendID);
                if (friend != null)
                {
                    Console.WriteLine("- " + friend.Name);
                }
            }
        }
    }

    public User FindUserByName(string name)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.Name == name)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public User FindUserByID(int userID)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void CountFriends(int userID)
    {
        User user = FindUserByID(userID);
        if (user != null)
        {
            Console.WriteLine(user.Name + " has " + user.FriendIDs.Count + " friends.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void DisplayAllUsers()
    {
        User temp = head;
        while (temp != null)
        {
            Console.WriteLine("User ID: " + temp.UserID + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Friends: " + temp.FriendIDs.Count);
            temp = temp.Next;
        }
    }
    static void Main(string[] args)
    {
        SocialMediaSystem sms = new SocialMediaSystem();

        sms.AddUser(1, "Yash", 25);
        sms.AddUser(2, "Vedant", 28);
        sms.AddUser(3, "Raghav", 22);
        sms.AddUser(4, "Rajat", 30);

        sms.AddFriendConnection(1, 2);
        sms.AddFriendConnection(1, 3);
        sms.AddFriendConnection(2, 4);
        sms.AddFriendConnection(3, 4);

        Console.WriteLine("All users and their friend count:");
        sms.DisplayAllUsers();

        Console.WriteLine("Display all friends of Yash:");
        sms.DisplayAllFriends(1);

        Console.WriteLine("Display all friends of Vedant:");
        sms.DisplayAllFriends(2);

        Console.WriteLine("Mutual friends between Yash and Vedant:");
        var mutualFriends = sms.FindMutualFriends(1, 2);
        foreach (int friendID in mutualFriends)
        {
            User user = sms.FindUserByID(friendID);
            Console.WriteLine("- " + user.Name);
        }

        Console.WriteLine("Count the number of friends for each user:");
        sms.CountFriends(1);
        sms.CountFriends(2);
        sms.CountFriends(3);
        sms.CountFriends(4);

        Console.WriteLine("Removing the friend connection between Yash and Vedant.");
        sms.RemoveFriendConnection(1, 2);

        Console.WriteLine("All users and their updated friend count:");
        sms.DisplayAllUsers();
    }
}
