﻿namespace WebApplication1.Models.Repositories
{
    public interface ICategoryRepository
    {
        Category GetById(int Id);
        IList<Category> GetAll();
        void Add(Category t);
        Category Update(Category t);
        void Delete(int Id);
    }
}
