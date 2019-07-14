using System;
using System.Collections.Generic;
using System.Text;
using WebAppProto.Data.Models;
using WebAppProto.Domain.Entities;

namespace WebAppProto.Data.Mapper
{
    public class ClientMapper : IClientMapper
    {
        public Client Map(Clients tbClient)
        {
            if (tbClient ==null)
            {
                return null;
            }
            Client client = new Client()
            {
                Id          = tbClient.Id,
                Name        = tbClient.Name,
                Lastname    = tbClient.Lastname,
                Email       = tbClient.Email
            };
            return client;
        }

        public Clients Map(Client client)
        {
            if (client == null)
            {
                return null;
            }
            Clients tbClient = new Clients()
            {
                Id = client.Id,
                Name = client.Name,
                Lastname = client.Lastname,
                Email = client.Email
            };
            return tbClient;

        }
    }
}
