using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class PostData
    {
        public Post Find(int id)
        {
            Db db = new Db();
            return db.Post.Find(id);

        }
        
        public List<Post> FindAll()
        {
            Db db = new Db();
            return db.Post.ToList();
        }

        public void Insert(Post obj)
        {
            try
            {
                Db db = new Db();
                db.Post.Add(obj);
                db.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public void Delete(int id)
        {
            Db db = new Db();
            Post post = db.Post.Find(id);
            db.Post.Remove(post);
            db.SaveChanges();
        }

        public void Update(Post obj)
        {
            Db db = new Db();
            db.Entry(obj).State = System.Data.EntityState.Modified;
            db.SaveChanges();

        }
    }
}