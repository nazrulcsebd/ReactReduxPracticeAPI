using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactReduxPractice.Models
{
    public class UserDemo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationId { get; set; }
        public string Address { get; set; }

        public List<UserDemo> UserDemoData()
        {
            var users = new List<UserDemo>()
            {
                new UserDemo()
                {
                    Id = 1,
                    Name = "a",
                    NationId = "1",
                    Address = "Dhaka"
                },
                new UserDemo()
                {
                    Id = 2,
                    Name = "b",
                    NationId = "19",
                    Address = "Khulna"
                },
                new UserDemo()
                {
                    Id = 3,
                    Name = "c",
                    NationId = "12",
                    Address = "Rupsa"
                },
                new UserDemo()
                {
                    Id = 4,
                    Name = "d",
                    NationId = "13",
                    Address = "Bagerhat"
                },
                new UserDemo()
                {
                    Id = 5,
                    Name = "e",
                    NationId = "20",
                    Address = "Fokirhat"
                },
                new UserDemo()
                {
                    Id = 6,
                    Name = "f",
                    NationId = "14",
                    Address = "Demra"
                },
                new UserDemo()
                {
                    Id = 7,
                    Name = "g",
                    NationId = "15",
                    Address = "Kustia"
                },
                new UserDemo()
                {
                    Id = 8,
                    Name = "h",
                    NationId = "16",
                    Address = "Meherpur"
                },
                new UserDemo()
                {
                    Id = 9,
                    Name = "i",
                    NationId = "17",
                    Address = "Barisal"
                },
                new UserDemo()
                {
                    Id = 10,
                    Name = "j",
                    NationId = "18",
                    Address = "Coxesbazar"
                }
            };

            return users;
        }
    }
}
