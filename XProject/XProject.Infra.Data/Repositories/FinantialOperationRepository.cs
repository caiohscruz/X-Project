using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Domain.Entitities;
using XProject.Domain.Interfaces;

namespace XProject.Infra.Data.Repositories
{
    public class FinantialOperationRepository : IFinantialOperationRepository
    {
        private readonly ApplicationDbContext _context;

        public FinantialOperationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<FinantialOperation> Create(FinantialOperation operation)
        {
            _context.Add(operation);
            await _context.SaveChangesAsync();
            return operation;
        }

        public IQueryable<FinantialOperation> GetAll()
        {
            return _context.FinantialOperations;
        }

        public async Task<FinantialOperation?> GetById(string id)
        {
            return await _context.FinantialOperations.FindAsync(id);
        }
        
        public async Task<FinantialOperation> Update(FinantialOperation operation)
        {
            _context.Update(operation);
            await _context.SaveChangesAsync();
            return operation;
        }

        public async Task<FinantialOperation> Remove(FinantialOperation operation)
        {
            _context.Remove(operation);
            await _context.SaveChangesAsync();
            return operation;
        }
    }
}
