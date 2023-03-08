﻿using MinimalwebAPI.Models;

namespace MinimalwebAPI.Services
{
    public interface IPersonalDataService
    {
        Task<(bool Result, PersonalData PersonalData)> CreateAsync(PersonalData personalData);
        Task<bool> DeleteAsync(int id);
        Task<(bool Result, PersonalData PersonalData)> GetAsync(int id);
        Task<(bool Result, PersonalData PersonalData)> UpdateAsync(PersonalData personalData);
    }
}