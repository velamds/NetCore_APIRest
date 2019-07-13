using System;
using WebAppProto.Data.Repository;
using WebAppProto.Domain.Application;
using WebAppProto.Domain.Data.IRepository;
using WebAppProto.Domain.Entities;

namespace WebAppProto.Application
{
    public class ApplicationClient : IApplicationClient
    {
        private IRepoClient repoClient;

        public ApplicationClient()
        {
            repoClient = new RepoClient();
        }

        public Client Get(int id)
        {
            Client client = repoClient.Get(id);
            return client;
        }

        public Client Insert(Client client)
        {
            Client _client = repoClient.Insert(client);
            return _client;
        }
    }
}
