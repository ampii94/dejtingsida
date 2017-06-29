using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
   public class PostRepository : IDisposable
    {
        private DejtDbContext context;

        public PostRepository(DejtDbContext context)
        {
            this.context = context;
        }

        public bool PostMessage(User sender, User reciever, string content)
        {
            try
            {
                context.Posts.Add(new Post()
                {
                    Reciever = reciever,
                    Sender = sender,
                    Content = content,
                    Date = DateTime.Now
                });
                context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public Post getPostByID(int id)
        {
            var post = context.Posts.FirstOrDefault(x => x.PostId == id);
            return post;
        }

        public List<Post> GetPosts(User user)
        {
            try
            {
                return context.Users.FirstOrDefault(x => x.Email == user.Email).PostsRecieved.ToList();

            }
            catch(Exception)
            {
                return null;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
