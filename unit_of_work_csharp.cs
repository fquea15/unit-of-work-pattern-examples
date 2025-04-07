using System;
using System.Collections.Generic;

public interface IUnitOfWork : IDisposable {
    IUserRepository Users { get; }
    int Complete();
}

public class UnitOfWork : IUnitOfWork {
    private readonly AppDbContext _context;
    public IUserRepository Users { get; private set; }

    public UnitOfWork(AppDbContext context) {
        _context = context;
        Users = new UserRepository(_context);
    }

    public int Complete() => _context.SaveChanges();
    public void Dispose() => _context.Dispose();
}
