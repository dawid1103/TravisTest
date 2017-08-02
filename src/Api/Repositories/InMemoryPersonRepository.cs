using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Repositories
{
    public interface IPersonRepository
    {
        Task<ISet<Person>> GetAll();
        Task Add(Person Person);
    }

    public class InMemoryPersonRepositiory : IPersonRepository
    {
        private ISet<Person> _persons = new HashSet<Person>();

        public async Task Add(Person Person)
        {
            _persons.Add(Person);
            await Task.CompletedTask;
        }

        public async Task<ISet<Person>> GetAll()
        {
            return await Task.FromResult(_persons);
        }
    }
}