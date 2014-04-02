using Blog.Data;
using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business
{
    public class PostBusiness
    {
        public Post Find(int id)
        {
            PostData data = new PostData();
            return data.Find(id);
        }

        public List<Post> FindAll()
        {
            PostData data = new PostData();
            return data.FindAll();
        }

        public void Insert(Post obj)
        {
            try
            {
                obj.Date = DateTime.Now;
                PostData data = new PostData();
                data.Insert(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            PostData data = new PostData();
            data.Delete(id);
        }

        public void Update(Post obj)
        {
            obj.Date = DateTime.Now;
            PostData data = new PostData();
            data.Update(obj);
        }
    }
}