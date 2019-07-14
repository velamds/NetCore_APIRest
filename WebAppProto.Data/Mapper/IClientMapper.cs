using System;
using System.Collections.Generic;
using System.Text;
using WebAppProto.Data.Models;
using WebAppProto.Domain.Entities;

namespace WebAppProto.Data.Mapper
{
    public interface IClientMapper
    {
        Client Map(Clients tbClient);
        Clients Map(Client client);
    }
}
