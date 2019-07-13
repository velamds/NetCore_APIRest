using System;
using System.Collections.Generic;
using System.Text;
using WebAppProto.Domain.Entities;

namespace WebAppProto.Domain.Data.IRepository
{
    public interface IRepoClient
    {
        Client Get(int id);

        Client Insert(Client client);
    }
}
