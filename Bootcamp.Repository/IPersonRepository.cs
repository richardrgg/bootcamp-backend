using Bootcamp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Repository
{
    public interface IPersonRepository
    {
        Task<int> Create(Person person);
    }
}
