using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppProto.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}
