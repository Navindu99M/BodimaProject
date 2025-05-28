﻿using bodimabackend.Models;
namespace bodimabackend.Services
{
    public interface IPropertyService
    {
        Task<IEnumerable<Property>> GetAllAsync();
        Task<Property> GetByIdAsync(int id);
        Task<Property> CreateAsync(Property property);
        Task<Property> UpdateAsync(Property property);
        Task<IEnumerable<Property>> GetPropertiesByOwnerIdAsync(int ownerId);
        Task DeleteAsync(int id);
    }
}
