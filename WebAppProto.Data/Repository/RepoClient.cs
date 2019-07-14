using System;
using System.Collections.Generic;
using System.Text;
using WebAppProto.Domain.Data.IRepository;
using WebAppProto.Domain.Entities;
using System.Linq;
using WebAppProto.Data.Mapper;
using WebAppProto.Data.Models;

namespace WebAppProto.Data.Repository
{
    public class RepoClient : IRepoClient
    {
        private IClientMapper clientMapper;

        public RepoClient(IClientMapper _clientMapper)
        {
            clientMapper = _clientMapper;
        }

        public Client Get(int id)
        {
            Client client = null;

            using (MyContext context=new MyContext())
            {
                var result = context.Clients.FirstOrDefault(c => c.Id == id);
                client = clientMapper.Map(result);
            }
            return client;
        }

        public Client Insert(Client client)
        {
            Clients TBclient = clientMapper.Map(client);
            using (MyContext context=new MyContext())
            {
                var result = context.Clients.Add(TBclient);
                context.SaveChanges();
                client = clientMapper.Map(TBclient);
            }
            return client;
        }
    }
}
