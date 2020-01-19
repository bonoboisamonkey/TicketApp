using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    static class Database
    {
        private static ArrayList users;
        private static ArrayList tickets;

        static Database()
        {
            tickets = new ArrayList();
            users = new ArrayList();
            User admin = new User()
            {
                name = "admin",
                surname = "admin",
                email = "admin@gmail.com",
                password = "admin"
            };
            users.Add(admin);
        }

        public static void AddUser(User user)
        {
            if (!HasUser(user))
            {
                users.Add(user);
            }
        }

        public static User GetUser(string email, string pass)
        {
            User FoundUser = null;
            foreach(User item in users)
            {
                if(item.email == email && item.password == pass)
                {
                    FoundUser = item;
                    break;
                }
            }
            return FoundUser;
        }

        public static Ticket GetTickets(string text)
        {
            Ticket ticketFound = null;
            foreach(Ticket ticket in tickets)
            {
                if (ticket.ticketName == text)
                {
                    ticketFound = ticket;
                    break;
                }
            }
            return ticketFound;
        }

        private static bool HasUser(User user)
        {
            bool flag = false;
            foreach(User item in users)
            {
                if(item.name == user.name && item.password == user.password)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public static User[] GetAllUsers()
        {
            return (User[])users.ToArray(typeof(User));
        }

       

        public static void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public static Ticket[] GetAllTickets()
        {
            return (Ticket[])tickets.ToArray(typeof(Ticket));
        }
    }
}
