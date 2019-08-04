using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acme.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Acme.Data.Repository.Impl
{
    public class AddressRepository : BaseRepository, IAddressRepository
    {
        // private readonly AcmeContext _context;
        private DbSet<Country> countryEntity;
        private DbSet<Postcodes> postcodeEntity;

        /// <summary>
        /// Address repository constructor
        /// </summary>
        /// <param name="context">Acme DB context</param>
        public AddressRepository(AcmeContext context): base(context)
        {
            // Set Country Entity
            countryEntity = _context.Set<Country>();

            // Set Postcode Entity
            postcodeEntity = _context.Set<Postcodes>();
        }

        /// <summary>
        /// Repository method to get Country list
        /// </summary>
        /// <returns>Country list</returns>
        public IEnumerable<Country> GetCountryList()
        {
            return countryEntity.ToList().AsEnumerable();
        }

        /// <summary>
        /// Repository method to get Postcode list
        /// </summary>
        /// <returns>Postcode list</returns>
        public IEnumerable<Postcodes> GetPostcodes()
        {
            return postcodeEntity.AsEnumerable();
        }
    }
}
