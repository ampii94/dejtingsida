using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class FriendRepository : IDisposable
    {
        public DejtDbContext context { get; set; }

        public FriendRepository(DejtDbContext context)
        {
            this.context = context;
        }

        public List<Friend> getRequestsRecieved(User user)
        {
            try
            {
                var friends = context.Users.FirstOrDefault(x => x.Email == user.Email).RequestsRecieved.ToList();
                return friends;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public List<Friend> getFriendRequestsSent(User user)
        {
            try
            {
                var friends = context.Users.FirstOrDefault(x => x.Email == user.Email).RequestsSent.ToList();
                return friends;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public bool checkIfRequestSent(User sender, User reciever)
        {
            try
            {
                var friendSent = context.Users.FirstOrDefault(x => x.Email == sender.Email).RequestsSent.ToList();
                var friendRecieved = context.Users.FirstOrDefault(x => x.Email == sender.Email).RequestsRecieved.ToList();
                foreach (var friend in friendSent)
                {
                    if (friend.SenderId == sender.UserId && friend.RecieverId == reciever.UserId)
                    {
                        return true;
                    }
                }
                foreach (var friend in friendRecieved)
                {
                    if (friend.SenderId == reciever.UserId && friend.RecieverId == sender.UserId)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
           public List<User> getRecievedRequests(User user)
        {
            try
            {
                var friendRequests = getRequestsRecieved(user);
                UserRepository userRep = new UserRepository(context);
                List<User> recievedRequests = new List<User>();
                foreach ( var friend in friendRequests)
                {
                    if (friend.RecieverId == user.UserId && !friend.Accepted)
                    {
                        recievedRequests.Add(userRep.getUserByID(friend.SenderId));
                    }
                }
                return recievedRequests;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public KeyValuePair<Friend, bool> GetFriend(string email, string friendEmail)
        {
            try
            {
                var userRep = new UserRepository(context);
                var user = userRep.GetUser(email);
                var friend = userRep.GetUser(friendEmail);
                var friendship = context.Friends.FirstOrDefault(x => x.RecieverId == user.UserId && x.SenderId == friend.UserId && x.Accepted);
                var actualUserIsReciver = true;

                if (friendship == null)
                {
                    actualUserIsReciver = false;
                    friendship = context.Friends.FirstOrDefault(x => x.RecieverId == friend.UserId && x.SenderId == user.UserId && x.Accepted);
                  
                }
                return new KeyValuePair<Friend, bool>(friendship, actualUserIsReciver);
            }
            catch(Exception)
            {
                return new KeyValuePair<Friend, bool>(null, false);
            }
        }

        public List<User> getAllFriends(User user)
        {
            try
            {
                var friendRequestRecieved = getRequestsRecieved(user);
                var friendRequestSent = getFriendRequestsSent(user);
                UserRepository userRep = new UserRepository(context);
                List<User> friendList = new List<User>();
                foreach ( var friend in friendRequestRecieved)
                {
                    if (friend.RecieverId == user.UserId && friend.Accepted)
                    {
                        friendList.Add(userRep.getUserByID(friend.SenderId));
                    }
                }
                foreach (var friend in friendRequestSent)
                {
                    if (friend.SenderId == user.UserId && friend.Accepted)
                    {
                        friendList.Add(userRep.getUserByID(friend.RecieverId));
                    }
                }
                return friendList;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public bool checkIfFriends(User user, User visiting)
        {
            try
            {
                var friendRequest = getFriendRequestsSent(user);
                UserRepository userRep = new UserRepository(context);
                foreach (var friend in friendRequest)
                {
                    if (friend.SenderId == user.UserId && !friend.Accepted && visiting.UserId == friend.RecieverId)
                    {
                        return false;
                    }
                }
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }

        public void acceptRequest(User sender, User reciever)
        {
            var friends = context.Friends.FirstOrDefault(x => x.SenderId == sender.UserId && x.RecieverId == reciever.UserId);
            if (friends != null)
            {
                friends.Accepted = true;
                context.SaveChanges();
            }
        }

        public bool sendRequest(string sender, string reciever)
        {
            var userRep = new UserRepository(context);
            var user = userRep.GetUser(sender);
            var recieverFriend = userRep.GetUser(reciever);
            try
            {
                context.Friends.Add(new Friend()
                {
                    Sender = user,
                    Reciever = recieverFriend,
                    Accepted = false
                });
                context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    
}
