using System;
using System.Collections.Generic;
using System.Text;
using WebAppProto.Domain.Entities;

namespace WebAppProto.Domain.Application
{
    public interface IApplicationClient
    {
        Client Get(int id);

        Client Insert(Client client);
    }
}
