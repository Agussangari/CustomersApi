using CustomersApi.dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CustomersApi.Repositories
{
    public class CustomerDatabaseContext : DbContext
    {
        //aca pongo el mismo nombre de la tabla desde aca ya se puede acceder a la tabla con este caso de uso.
        public DbSet<CustomerEntity> Customer { get; set; }

        public async Task<CustomerEntity> Get(long id)
        {
            return await  Customer.FirstAsync(x => x.Id == id);
        }

        
        public async Task<CustomerEntity> Add(CreateCustomerDto customerDto)
        {
            CustomerEntity entity = new CustomerEntity()
            {
                Id = null,
                Address = customerDto.Address,
                Email = customerDto.Email,
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,    
            };
            EntityEntry<CustomerEntity> response = await Customer.AddAsync(entity);
            await SaveChangesAsync();
            return await Get(response.Entity.Id ?? throw new Exception("No se ha podido guardar"));
        }
    }

    public class CustomerEntity
    {
        public long? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }
}
