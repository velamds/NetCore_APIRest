using System;
using System.Collections.Generic;
using System.Text;
using WebAppProto.Domain.Data.IRepository;
using WebAppProto.Domain.Entities;

namespace WebAppProto.Data.Repository
{
    public class RepoClient : IRepoClient
    {
        public Client Get(int id)
        {
            Client mock = null;

            if (id == 1)
            {
                mock = new Client
                {
                    Id = 1,
                    Name = "Sergio",
                    Lastname = "Munoz",
                    Email = "velamds@gmail.com"
                };
            }

            return mock;
        }

        public Client Insert(Client client)
        {
            client.Id = new Random().Next(1, 100);
            return client;
        }
    }
}
