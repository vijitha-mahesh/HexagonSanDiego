using AutoMapper;
using HexagonSanDiego.Data;
using HexagonSanDiego.Dtos.AmenityDtos;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.Repository
{
    public class AmenityRepository : IAmenityRepository
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public AmenityRepository(IMapper mapper, DataContext context)
        {

            _context = context;
            _mapper = mapper;

        }
        public bool AddAmenity(AddAmenityDto addAmenity)
        {
            Amenity amenity = _mapper.Map<Amenity>(addAmenity);

            _context.Amenities.Add(amenity);
             _context.SaveChangesAsync();
            if (_context.SaveChanges() >= 0)
            {
                return true;

            }
            return false;
        }

        public bool DeleteAmenity(Amenity amenity)
        {
            try
            {
                Amenity Amenity = _context.Amenities

                    .FirstOrDefault(c => c.Id == amenity.Id);


                Amenity.Name = amenity.Name;
                Amenity.Status = amenity.Status;
                Amenity.Image = amenity.Image;
                Amenity.Image2 = amenity.Image2;
                Amenity.Image3 = amenity.Image3;
                Amenity.HasImage = amenity.HasImage;


                if (_context.SaveChanges() >= 0)
                {
                    return true;

                }
                return false;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<List<Amenity>> GetAmenity()
        {
            var plans = await _context.Amenities.
                ToListAsync();
            return plans;
        }

        public bool UpdateAmenity(Amenity amenity)
        {
            try
            {
                Amenity Amenity =  _context.Amenities

                    .FirstOrDefault(c => c.Id == amenity.Id);


                Amenity.Name = amenity.Name;
                Amenity.Status = amenity.Status;
                Amenity.Image = amenity.Image;
                Amenity.Image2 = amenity.Image2;
                Amenity.Image3 = amenity.Image3;
                Amenity.HasImage = amenity.HasImage;


                if (_context.SaveChanges() >= 0)
                {
                    return true;

                }
                return false;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
