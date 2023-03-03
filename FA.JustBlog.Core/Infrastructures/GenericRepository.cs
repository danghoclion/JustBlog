using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Infrastructures
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly JustBlogContext context;
        public GenericRepository() 
        {
            context = new JustBlogContext();
            this.entities = context.Set<TEntity>();
        }

        protected DbSet<TEntity> entities;
        public GenericRepository(JustBlogContext context)
        {
            this.context = context;
            this.entities= context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            this.entities.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = entities.Find(id);
            if (entity == null) return;
            Delete(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
           this.entities.Remove(entity);
            context.SaveChanges();
        }

        public TEntity Find(int id)
        {
            return entities.Find(id);
            context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities;
        }

        public void Update(TEntity entity)
        {
            //entities.Update(entity);
            context.Entry<TEntity>(entity).State= EntityState.Modified;
            context.SaveChanges();
        }
    }
}
